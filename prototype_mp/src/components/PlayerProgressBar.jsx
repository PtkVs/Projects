import {StyleSheet, Text, View} from 'react-native';
import React from 'react';
import {colors} from '../constants/color';
import {fontFamilies} from '../constants/fonts';
import {fontSizes, spacing} from '../constants/dimensions';
import {useSharedValue} from 'react-native-reanimated';
import {Slider} from 'react-native-awesome-slider';
import TrackPlayer, {useProgress} from 'react-native-track-player';
import {formatSecToMin} from '../utils/timeindex';

const PlayerProgressBar = () => {
  const {duration, position} = useProgress();

  const progress = useSharedValue(0.25);
  const min = useSharedValue(0);
  const max = useSharedValue(1);
  const isSliding = useSharedValue(false);
  if (!isSliding.value) {
    progress.value = duration > 0 ? position / duration : 0;
  }

  const trackElapsedTime = formatSecToMin(position);
  const RemainingTime = formatSecToMin(duration - position);

  return (
    <View>
      {/* Progress Bar */}
      <View style={styles.timeRowContainer}>
        <Text style={styles.timeText}>{trackElapsedTime}</Text>
        <Text style={styles.timeText}>
          {'-'}
          {RemainingTime}
        </Text>
      </View>

      {/* Progress Bar Component */}
      <Slider
        style={styles.sliderContainer}
        progress={progress}
        minimumValue={min}
        maximumValue={max}
        onSlidingStart={() => (isSliding.value = true)}
        onValueChange={async value => {
          await TrackPlayer.seekTo(value * duration);
        }}
        onSlidingComplete={async value => {
          if (!isSliding.value) {
            return;
          }
          isSliding.value = false;
          await TrackPlayer.seekTo(value * duration);
        }}
        theme={{
          maximumTrackTintColor: colors.maximumTintColor,
          minimumTrackTintColor: colors.minimumTintColor,
          bubbleBackgroundColor: colors.maximumTintColor,
        }}
      />
    </View>
  );
};

export default PlayerProgressBar;

const styles = StyleSheet.create({
  timeRowContainer: {
    flexDirection: 'row',
    justifyContent: 'space-between',
    alignItems: 'center',
  },
  timeText: {
    color: colors.textSecondary,
    fontFamily: fontFamilies.regular,
    fontSize: fontSizes.md,
  },
  sliderContainer: {
    height: 20,
    borderRadius: spacing.sm,
    marginVertical: spacing.lg,
  },
});
