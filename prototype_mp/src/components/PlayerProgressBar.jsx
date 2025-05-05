import {StyleSheet, Text, View} from 'react-native';
import React from 'react';
import {colors} from '../constants/color';
import {fontFamilies} from '../constants/fonts';
import {fontSizes, spacing} from '../constants/dimensions';
import {useSharedValue} from 'react-native-reanimated';
import {Slider} from 'react-native-awesome-slider';

const PlayerProgressBar = () => {
  const progress = useSharedValue(0.25);
  const min = useSharedValue(0);
  const max = useSharedValue(1);

  return (
    <View>
      {/* Progress Bar */}
      <View style={styles.timeRowContainer}>
        <Text style={styles.timeText}>0:00</Text>
        <Text style={styles.timeText}>{'-'}4:00</Text>
      </View>

      {/* Progress Bar Component */}
      <Slider
        style={styles.sliderContainer}
        progress={progress}
        minimumValue={min}
        maximumValue={max}
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
