import React from 'react';
import { View, Text, Image, ListView, TouchableHighlight } from 'react-native'

import { Card, ListItem, Button, Icon, SearchBar } from 'react-native-elements'


export default class SearchPage extends React.Component {
  state = {
    search: '',
    listWithAttractions: [],
    city: 'Plovdiv',
  };

  componentDidMount(){
    this.getPlaceByCity("Plovdiv").then(place => {
      console.log( place )
      this.setState({ listWithAttractions: place });
      });
  }

async getPlaceByCity( city ) {
    try {
        const apiCity = city;
        const placeApiCall = await fetch('https://maps.googleapis.com/maps/api/place/textsearch/json?query=' + apiCity + '+point+of+interest&language=en&key=AIzaSyAHjjWSp2RtReJ8AewRcYSwygZFy5vvJgY');
        const place = await placeApiCall.json();
        return place.results;
    } catch(err) {
        console.log("Error fetching data-----------", err);
    }
};

  updateSearch = search => {
    this.setState({ search });
  };

  submitSearch = () => {
    this.getPlaceByCity(this.state.search).then(places => {
      this.setState({ listWithAttractions: places });
      this.setState({ city: this.state.search });
      });
  };
  
  render() {
    const { search } = this.state;
    return (
        <View>
        <SearchBar
        placeholder="Type Here..."
        onChangeText={this.updateSearch}
        onSubmitEditing={this.submitSearch}
        value={search}
      />
      <Card
      title={this.state.city}>
    {
        this.state.listWithAttractions.map((u, i) => {
        return (
          <Card
          key={i}
          title={u.name}>
            <ListItem
            key={i}
            title={u.formatted_address}
            leftIcon={{ name: 'flight-takeoff' }}
            bottomDivider
            chevron
            />
            </Card>
        );
        })
         
    }
    </Card>

      </View>
    // <TouchableHighlight onPress={() => this.props.navigation.navigate("AttractionsListPage")}><View><Text>Huy</Text></View></TouchableHighlight>
    );
  }
}