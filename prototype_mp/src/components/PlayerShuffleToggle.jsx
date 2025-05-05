import {StyleSheet, Text, TouchableOpacity, View} from 'react-native';
import React from 'react';
import MaterialCommunityIcons from 'react-native-vector-icons/MaterialCommunityIcons';
import {colors} from '../constants/color';
import {iconSizes} from '../constants/dimensions';

const PlayerShuffleToggle = () => {
  return (
    <TouchableOpacity>
      <MaterialCommunityIcons
        name={'shuffle'}
        color={colors.iconSecondary}
        size={iconSizes.lg}
      />
    </TouchableOpacity>
  );
};

export default PlayerShuffleToggle;

const styles = StyleSheet.create({});
