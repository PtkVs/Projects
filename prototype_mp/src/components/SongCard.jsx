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
const SongCard = ({containerStyle, imageStyle}) => {
  return (
    <TouchableOpacity style={[styles.container, containerStyle]}>
      <Image source={{uri: imageUrl}} style={[styles.coverImage, imageStyle]} />
      <Text style={styles.title} numberOfLines={1}>
        All or Nothing
      </Text>
      <Text style={styles.artist} numberOfLines={1}>
        {' '}
        by The Beatles
      </Text>
    </TouchableOpacity>
  );
};

export default SongCard;

const styles = StyleSheet.create({
  container: {},

  coverImage: {
    width: 175,
    height: 190,
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
