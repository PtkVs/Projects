import {Image, StyleSheet, Text, TouchableOpacity, View} from 'react-native';
import React from 'react';

import AntDesign from 'react-native-vector-icons/AntDesign';
import Feather from 'react-native-vector-icons/Feather';
import {colors} from '../constants/color';
import {fontSizes, iconSizes, spacing} from '../constants/dimensions';
import {fontFamilies} from '../constants/fonts';
import PlayerRepeatToggle from '../components/PlayerRepeatToggle';
import PlayerShuffleToggle from '../components/PlayerShuffleToggle';
import PlayerProgressBar from '../components/PlayerProgressBar';
import {
  NextButton,
  PlayPauseButton,
  PreviousButton,
} from '../components/PlayerControls';
import {useActiveTrack} from 'react-native-track-player';

const imageUrl =
  'https://ncsmusic.s3.eu-west-1.amazonaws.com/tracks/000/001/805/325x325/your-burn-1731978054-rhCAZVNaIC.png';

const PlayerScreen = () => {
  //for using the active image of the playing
  const activeTrack = useActiveTrack();

  const isLiked = false;
  const isMute = false;
  return (
    <View style={styles.maincontainer}>
      {/* Header */}
      <View style={styles.headerContainer}>
        <TouchableOpacity>
          <AntDesign
            name={'arrowleft'}
            style={styles.arrowButton}
            color={colors.iconPrimary}
            size={iconSizes.lg}
          />
        </TouchableOpacity>
        <Text style={styles.headerText}>Playing Now</Text>
      </View>

      {/* Cover Image */}
      <View style={styles.coverImageContainer}>
        <Image
          source={{uri: activeTrack?.artwork}}
          style={styles.coverImage}></Image>
      </View>

      {/* Heart/Like Button, Atist and Ttle here */}
      <View style={styles.bodyContainer}>
        {/* Title and Artist */}
        <View style={styles.titleContainer}>
          <Text style={styles.songTitle}> {activeTrack?.title} </Text>
          <Text style={styles.artistName}> {activeTrack?.artist} </Text>
        </View>
        {/* Heart Button */}
        <TouchableOpacity>
          <AntDesign
            name={isLiked ? 'heart' : 'hearto'}
            color={colors.iconSecondary}
            size={iconSizes.md}
          />
        </TouchableOpacity>
      </View>

      {/* player control options like shuffle, repeat and volume  */}
      <View style={styles.playerControlContainer}>
        {/*Volume Button */}
        <TouchableOpacity style={styles.volumeButton}>
          <Feather
            name={isMute ? 'volume-x' : 'volume-1'}
            color={colors.iconSecondary}
            size={iconSizes.lg}
          />
        </TouchableOpacity>

        {/* Repeat and Shuffle Button */}
        <View style={styles.shuffleANDrepeatButton}>
          <PlayerRepeatToggle />
          <PlayerShuffleToggle />
        </View>
      </View>

      {/* Player Progress Bar */}
      <PlayerProgressBar />

      {/* Play and Pause Button */}
      <View style={styles.playPauseContainer}>
        <PreviousButton />
        <PlayPauseButton />
        <NextButton />
      </View>
    </View>
  );
};

export default PlayerScreen;

const styles = StyleSheet.create({
  maincontainer: {
    flex: 1,
    backgroundColor: colors.background,
    padding: spacing.lg,
  },
  headerContainer: {
    flexDirection: 'row',
    alignItems: 'center',
    width: '100%',
  },
  headerText: {
    flex: 1,
    textAlign: 'center',
    color: colors.textPrimary,
    fontSize: fontSizes.xl,
    fontFamily: fontFamilies.medium,
  },
  coverImage: {
    width: 300,
    height: 400,
    borderRadius: 10,
  },
  coverImageContainer: {
    alignItems: 'center',
    justifyContent: 'center',
    marginVertical: spacing.lg,
  },

  bodyContainer: {
    flexDirection: 'row',
    alignItems: 'center',
  },
  titleContainer: {
    flex: 1,
    alignItems: 'center',
    justifyContent: 'center',
  },
  songTitle: {
    color: colors.textPrimary,
    fontSize: fontSizes.xl,
    fontFamily: fontFamilies.medium,
    textAlign: 'center',
  },
  artistName: {
    color: colors.textSecondary,
    fontSize: fontSizes.lg,
    fontFamily: fontFamilies.regular,
    textAlign: 'center',
  },
  playerControlContainer: {
    flexDirection: 'row',
    justifyContent: 'space-between',
    alignItems: 'center',
    marginVertical: spacing.xl,
  },

  volumeButton: {
    flex: 1,
  },
  shuffleANDrepeatButton: {
    flexDirection: 'row',
    gap: spacing.xl,
  },
  playPauseContainer: {
    flexDirection: 'row',
    justifyContent: 'center',
    alignItems: 'center',
    gap: spacing.xl,
    padding: spacing.xl,
  },
});
