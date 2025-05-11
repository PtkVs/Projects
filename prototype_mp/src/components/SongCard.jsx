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
import TrackPlayer from 'react-native-track-player';

const imageUrl =
  'https://ncsmusic.s3.eu-west-1.amazonaws.com/tracks/000/001/864/325x325/all-or-nothing-1742259654-EKtAHFBDZm.png';
const SongCard = ({item, containerStyle, imageStyle, handlePlay}) => {
  return (
    <TouchableOpacity
      style={[styles.container, containerStyle]}
      onPress={() => handlePlay(item)}>
      <Image
        source={{uri: item.artwork}}
        style={[styles.coverImage, imageStyle]}
      />
      {/* {item?.title and item.title its same } */}
      {/*If item exists, it returns item.title. If item is undefined or null, it returns undefined without throwing an error. so its a safe way to access properties in objects that might not be loaded or availabe yet which prevents from crashing app*/}
      <Text style={styles.title} numberOfLines={1}>
        {item?.title}
      </Text>

      <Text style={styles.artist} numberOfLines={1}>
        {item.artist}
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
