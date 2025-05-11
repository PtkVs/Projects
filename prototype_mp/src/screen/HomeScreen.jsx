import {FlatList, StyleSheet, Text, View} from 'react-native';
import React from 'react';
import Header from '../components/Header';
import {colors} from '../constants/color';
import {fontFamilies} from '../constants/fonts';
import {fontSizes, spacing} from '../constants/dimensions';
import SongCard from '../components/SongCard';
import SongCardWithCategory from '../components/SongCardWithCategory';
import FloatingPlayer from '../components/FloatingPlayer';
import {songsWithCategory} from '../data/songsWithCategory';

const HomeScreen = () => {
  return (
    <View style={styles.container}>
      <Header></Header>
      {/* Yo flatlist is main vertical(parent container) rendering component like container which contains all other sub(child container) rendering containers */}
      <FlatList
        data={songsWithCategory}
        renderItem={SongCardWithCategory}
        contentContainerStyle={{
          paddingBottom: 200,
        }}
      />
      <FloatingPlayer />
    </View>
  );
};

export default HomeScreen;

const styles = StyleSheet.create({
  container: {
    flex: 1,
    backgroundColor: colors.background,
  },
});
