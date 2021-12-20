import * as React from 'react';
import { Block } from '../../Block/Block';
import { BLOCK_TITLES } from '../../../common/enums/block-titles';
import { List } from '../../List/List';
import { ListItem } from '../../ListItem/ListItem';

import './Tabs.scss';

export const Tabs = () => {
  return (
    <Block title={BLOCK_TITLES.NAVIGATION} percentWidth={25}>
      <List>
        <ListItem link="requests/pending-requests">New applications</ListItem>
        <ListItem link="users/users">Users</ListItem>
        <ListItem link="users/psychologists">Psychologists</ListItem>
        <ListItem link="library/">Library</ListItem>
        <ListItem link="tests/">Tests</ListItem>
      </List>
    </Block>
  );
};
