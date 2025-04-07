import {FlatList, StyleSheet, Text, View} from 'react-native';
import React from 'react';
import Header from '../components/Header';
import {colors} from '../constants/color';
import {fontFamilies} from '../constants/fonts';
import {fontSizes, spacing} from '../constants/dimensions';
import SongCard from '../components/SongCard';
import SongCardWithCategory from '../components/SongCardWithCategory';
import FloatingPlayer from '../components/FloatingPlayer';

const HomeScreen = () => {
  return (
    <View style={styles.container}>
      <Header></Header>
      <FlatList
        data={[1, 2, 3, 4, 5]}
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
