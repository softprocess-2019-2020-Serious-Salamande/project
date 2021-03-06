/**
 * Sample React Native App
 * https://github.com/facebook/react-native
 *
 * @format
 * @flow
 */

import React from 'react';

import {
  Header,
  LearnMoreLinks,
  Colors,
  DebugInstructions,
  ReloadInstructions,
} from 'react-native/Libraries/NewAppScreen';

import {createAppContainer} from 'react-navigation';
import {createStackNavigator} from 'react-navigation-stack';

import SearchPage from './pages/SearchPage';
import AttractionsListPage from './pages/AttractionsListPage';


const MainNavigator = createStackNavigator({
  SearchPage: { screen: SearchPage },
  AttractionsListPage: { screen: AttractionsListPage }
});

export default createAppContainer(MainNavigator);
