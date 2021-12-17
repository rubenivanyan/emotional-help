import { BLOCK_TITLES } from '../../../common/enums/block-titles';
import { Block } from '../../Block/Block';
import React from 'react';
import './Library.scss';
import { Outlet } from 'react-router-dom';
import Box from '@mui/material/Box';
import Tab from '@mui/material/Tab';
import TabContext from '@mui/lab/TabContext';
import TabList from '@mui/lab/TabList';
import TabPanel from '@mui/lab/TabPanel';
import { Music } from '../Music/Music';
import { Films } from '../Films/Films';
import { Books } from '../Books/Books';
import { Games } from '../Games/Games';

export const Library = () => {
  const [value, setValue] = React.useState('1');

  const handleChange = (event: React.SyntheticEvent, newValue: string) => {
    setValue(newValue);
  };
  return (
    <Block title={BLOCK_TITLES.LIBRARY} percentWidth={60}>
      <Box sx={{ width: '100%', typography: 'body1' }}>
        <TabContext value={value}>
          <Box sx={{ borderBottom: 1, borderColor: 'divider' }}>
            <TabList onChange={handleChange} sx={{ color: 'success.main' }}>
              <Tab label="Music" value="1" />
              <Tab label="Films" value="2" />
              <Tab label="Books" value="3" />
              <Tab label="Games" value="4" />
            </TabList>
          </Box>
          <TabPanel value="1">
            <Music />
          </TabPanel>
          <TabPanel value="2">
            <Films />
          </TabPanel>
          <TabPanel value="3">
            <Books />
          </TabPanel>
          <TabPanel value="4">
            <Games />
          </TabPanel>
        </TabContext>
      </Box>
      <Outlet />
    </Block>
  );
};
