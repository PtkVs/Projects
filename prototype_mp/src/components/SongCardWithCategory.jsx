import {FlatList, StyleSheet, Text, View} from 'react-native';
import React from 'react';
import {spacing} from '../constants/dimensions';
import SongCard from './SongCard';
import {colors} from '../constants/color';
import {fontFamilies} from '../constants/fonts';
import {fontSizes} from '../constants/dimensions';

const SongCardWithCategory = () => {
  return (
    <View style={styles.container}>
      <Text style={styles.headingText}> Recommended For You</Text>

      {/* flat list le  scrollview/ feature ko lagi use hunxa */}
      <FlatList
        data={[1, 2, 3, 4, 5]}
        renderItem={SongCard}
        horizontal={true}
        ItemSeparatorComponent={() => <View style={{marginHorizontal: 10}} />}
        contentContainerStyle={{paddingHorizontal: spacing.md}}
      />
    </View>
  );
};

export default SongCardWithCategory;

const styles = StyleSheet.create({
  container: {
    flex: 1,
  },

  headingText: {
    fontSize: fontSizes.lg,
    color: colors.textPrimary,
    fontFamily: fontFamilies.bold,
    paddingVertical: spacing.md,
    paddingHorizontal: spacing.md,
  },
});
