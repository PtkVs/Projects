// *******ORIGINAL CODE********** */
import {Image, StyleSheet, Text, TouchableOpacity, View} from 'react-native';
import React, {use} from 'react';
import {colors} from '../constants/color';
import {fontSizes, spacing} from '../constants/dimensions';
import {fontFamilies} from '../constants/fonts';
import {
  NextButton,
  PlayPauseButton,
  PreviousButton,
} from '../components/PlayerControls';
import {useSharedValue} from 'react-native-reanimated';
import {Slider} from 'react-native-awesome-slider';
import MovingText from './MovingText';
import {useNavigation} from '@react-navigation/native';
import {useActiveTrack} from 'react-native-track-player';
import PlayerProgressBar from '../components/PlayerProgressBar';

const imageUrl =
  'https://linkstorage.linkfire.com/medialinks/images/8b14b1ae-c3ea-4484-a654-3bab3a07ddea/artwork-440x440.jpg';
const FloatingPlayer = () => {
  const activeTrack = useActiveTrack();

  const navigation = useNavigation();
  const progress = useSharedValue(30);
  const min = useSharedValue(0);
  const max = useSharedValue(100);

  const handleOpenPlayerScreen = () => {
    navigation.navigate('PLAYER_SCREEN');
  };
  // useNavigation is a hook that returns the navigation object. It is used to navigate between screens.

  return (
    <View>
      {/* Slider Section  this is og player section */}
      <View style={{zIndex: 1}}>
        {/* zIndex is needed to make the slider visible
        <Slider
          style={styles.sliderContainer}
          progress={progress}
          minimumValue={min}
          maximumValue={max}
          theme={{
            minimumTrackTintColor: colors.minimumTintColor,
            maximumTrackTintColor: colors.maximumTintColor,
            bubbleBackgroundColor: colors.maximumTintColor,
          }}
          // containerStyle={{height: 20}} //containerStyle le chai slider kati ko thick banaune vanera use garinxa(see docementation of awesome slider)
        /> */}

        <PlayerProgressBar />
      </View>

      {/* Player Controls Section */}
      <TouchableOpacity
        style={styles.container}
        activeOpacity={0.7}
        onPress={handleOpenPlayerScreen}>
        {/*ternary operator use gareko to check artwork i.e is artwork valid if true then use artwork if not display nothing null is passed */}
        {activeTrack?.artwork ? (
          <Image
            source={{uri: activeTrack.artwork}}
            style={styles.coverImage}
          />
        ) : null}

        {/* yeha pani ternary operator use garna sakinxa */}
        {/*{activeTrack ? (
  <View style={styles.titleContainer}>
    <MovingText
      text={activeTrack.title}
      animationThreshold={15}
      style={styles.title}
    />
    <Text style={styles.artist}>{activeTrack.artist}</Text>
  </View>
) : null}*/}
        <View style={styles.titleContainer}>
          <MovingText
            text={activeTrack?.title || 'Song Title'}
            animationThreshold={15}
            style={styles.title}
          />

          <Text style={styles.artist}>{activeTrack?.artist}</Text>
        </View>
        <View style={styles.playerControlContainer}>
          <PreviousButton />
          <PlayPauseButton />
          <NextButton />
        </View>
      </TouchableOpacity>
    </View>
  );
};

export default FloatingPlayer;

const styles = StyleSheet.create({
  container: {
    flexDirection: 'row',
    alignItems: 'center',
    paddingBottom: spacing.md,
  },
  sliderContainer: {
    width: 200,
    height: 20,
    marginTop: spacing.md,
  },
  coverImage: {
    width: 70,
    height: 70,
  },
  titleContainer: {
    flex: 1,
    paddingHorizontal: spacing.md,
    overflow: 'hidden',
    marginLeft: spacing.sm,
    marginRight: spacing.sm,
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
