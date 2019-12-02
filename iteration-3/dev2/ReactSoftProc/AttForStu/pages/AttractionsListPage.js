import React from 'react';
import { View, Text } from 'react-native'

// import { SearchBar } from 'react-native-elements';

export default class AttractionsListPage extends React.Component {
  state = {
    search: '',
  };

// async getPlaceByCity( city ) {
//     try {
//         const apiCity = city;
//         const placeApiCall = await fetch('https://maps.googleapis.com/maps/api/place/textsearch/json?query=' + apiCity + '+point+of+interest&language=en&key=AIzaSyAHjjWSp2RtReJ8AewRcYSwygZFy5vvJgY');
//         const place = await placeApiCall.json();
//         return place;
//     } catch(err) {
//         console.log("Error fetching data-----------", err);
//     }
// };
// // getPlaceByCity( "Odesa" );

//   updateSearch = search => {
//     this.setState({ search });
//   };

  render() {
    const { search } = this.state;

    return (
<View><Text>Pizda</Text></View>
    );
  }
}