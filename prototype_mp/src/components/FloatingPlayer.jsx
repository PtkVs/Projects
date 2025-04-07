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
import {fontSizes, spacing} from '../constants/dimensions';
import {fontFamilies} from '../constants/fonts';
import {
  NextButton,
  PlayPauseButton,
  PreviousButton,
} from '../components/PlayerControls';

const imageUrl =
  'https://linkstorage.linkfire.com/medialinks/images/8b14b1ae-c3ea-4484-a654-3bab3a07ddea/artwork-440x440.jpg';
const FloatingPlayer = () => {
  return (
    <TouchableOpacity style={styles.container} activeOpacity={0.7}>
      <Image source={{uri: imageUrl}} style={styles.coverImage} />
      <View style={styles.titleContainer}>
        <Text style={styles.title}>Rick and Morty</Text>
        <Text style={styles.artist}>Nicklodian</Text>
      </View>
      <View style={styles.playerControlContainer}>
        <PreviousButton />
        <PlayPauseButton />
        <NextButton />
      </View>
    </TouchableOpacity>
  );
};

export default FloatingPlayer;

const styles = StyleSheet.create({
  container: {
    flexDirection: 'row',
    alignItems: 'center',
    paddingBottom: spacing.md,
  },
  coverImage: {
    width: 70,
    height: 70,
  },
  titleContainer: {
    flex: 1,
    paddingHorizontal: spacing.md,
  },
  title: {
    color: colors.textPrimary,
    fontSize: fontSizes.lg,
    fontFamily: fontFamilies.medium,
  },
  artist: {
    color: colors.textSecondary,
    fontSize: fontSizes.md,
    fontFamily: fontFamilies.regular,
  },
  playerControlContainer: {
    flexDirection: 'row',
    alignItems: 'center',
    gap: spacing.md,
    paddingRight: spacing.lg,
  },
});
