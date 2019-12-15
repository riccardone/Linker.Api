using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using EventStore.LinkerApi.Models;
using EventStore.LinkerApi.Services;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;

namespace EventStore.LinkerApi.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class LinksController : ControllerBase
    {
        private readonly ILinksReader _linksReader;

        public LinksController(ILinksReader linksReader)
        {
            _linksReader = linksReader;
        }

        // GET: api/Links
        [HttpGet]
        public IEnumerable<ExistingLink> Get()
        {
            var results = _linksReader.Get().ToList();
            Response.Headers.Add("X-Total-Count", $"{results.Count()}");
            return results;
        }

        // GET: api/Links/5
        [HttpGet("{id}", Name = "Get")]
        public ExistingLink GetById(string id)
        {
            return _linksReader.Get(id);
        }

        // POST: api/Links
        [HttpPost]
        public async Task<IActionResult> Post([FromBody] CreateLinkRequest value)
        {
            if (value.Id == null)
                value.Id = Guid.NewGuid().ToString();
            // TODO
            return CreatedAtAction(nameof(GetById), new { id = value.Id }, new CreateLinkResponse());
        }

        // PUT: api/Links/5
        [HttpPut("{id}")]
        public void Put(string id, [FromBody] string value)
        {
        }

        // DELETE: api/ApiWithActions/5
        [HttpDelete("{id}")]
        public void Delete(string id)
        {
        }
    }
}
