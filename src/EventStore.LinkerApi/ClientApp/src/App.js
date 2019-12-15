import React from 'react';
import './App.css';
import { Admin, Resource, ListGuesser } from 'react-admin';
import jsonServerProvider from 'ra-data-json-server';

const dataProvider = jsonServerProvider('https://localhost:5001');
const App = () => (
      <Admin dataProvider={dataProvider} options={{label:'test'}}>
          <Resource name="links" options={{label: 'Links'}} list={ListGuesser} />
      </Admin>
  );

export default App;