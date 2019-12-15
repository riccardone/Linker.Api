import React from 'react';
import { List, Datagrid, TextField, BooleanField, DateField, ArrayField } from 'react-admin';

export const LinkList = props => (
    <List {...props}>
        <Datagrid rowClick="edit">
            <TextField source="id" />
            <TextField source="origin" />
            <TextField source="destination" />
            <BooleanField source="IsRunning" />
            <DateField  source="startedat" />
            <ArrayField source="stats" />
        </Datagrid>
    </List>
);