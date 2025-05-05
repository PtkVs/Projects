import {StyleSheet, Text, View} from 'react-native';
import React, {useEffect} from 'react';
import Animated, {
  useAnimatedStyle,
  useSharedValue,
  withTiming,
  withRepeat,
  withDelay,
  Easing,
} from 'react-native-reanimated';

const MovingText = ({text, animationThreshold, style}) => {
  const translateX = useSharedValue(0);
  const shouldAnimate = text.length >= animationThreshold;
  const textWidth = text.length * 3;

  //useEffect to animate the text when the text length is greater than the threshold value and the animation is not running already (shouldAnimate)
  useEffect(() => {
    if (!shouldAnimate) return; //if false do nothing

    //if true animate
    translateX.value = withDelay(
      1000,
      withRepeat(
        withTiming(-textWidth, {duration: 5000, easing: Easing.linear}),
        -1,
        true,
      ),
    ); //-1 means infinite times to repeat the animation and true means it will repeat forever
  }, [translateX, text, animationThreshold, textWidth]);

  const animatedStyle = useAnimatedStyle(() => {
    return {
      transform: [{translateX: translateX.value}],
    };
  });
  return (
    <Animated.Text
      numberOfLines={1}
      style={[
        animatedStyle,
        style,
        shouldAnimate && {width: 9999, paddingLeft: 16},
      ]}>
      {text}
    </Animated.Text>
  );
};

export default MovingText;

const styles = StyleSheet.create({});
