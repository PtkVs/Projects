import {
  Image,
  StyleSheet,
  Text,
  Touchable,
  TouchableOpacity,
  View,
} from 'react-native';
import React from 'react';
import {colors} from '../constants/color';
import {fontFamilies} from '../constants/fonts';
import {fontSizes, spacing} from '../constants/dimensions';

const imageUrl =
  'https://ncsmusic.s3.eu-west-1.amazonaws.com/tracks/000/001/864/325x325/all-or-nothing-1742259654-EKtAHFBDZm.png';
const SongCard = () => {
  return (
    <TouchableOpacity style={styles.container}>
      <Image source={{uri: imageUrl}} style={styles.coverImage} />
      <Text style={styles.title}>All or Nothing</Text>
      <Text style={styles.artist}> by The Beatles</Text>
    </TouchableOpacity>
  );
};

export default SongCard;

const styles = StyleSheet.create({
  container: {
    height: 300,
    width: 190,
  },

  coverImage: {
    width: 200,
    height: 200,
    borderRadius: 10,
  },

  title: {
    color: colors.textPrimary,
    fontFamily: fontFamilies.medium,
    textAlign: 'center',
    fontSize: fontSizes.md,
    paddingHorizontal: spacing.sm,
  },

  artist: {
    color: colors.textSecondary,
    fontFamily: fontFamilies.regular,
    textAlign: 'center',
    fontSize: fontSizes.sm,
    paddingVertical: spacing.xs,
  },
});
