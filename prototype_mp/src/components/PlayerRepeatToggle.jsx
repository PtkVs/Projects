import {StyleSheet, Text, View, TouchableOpacity} from 'react-native';
import React from 'react';
import MaterialCommunityIcons from 'react-native-vector-icons/MaterialCommunityIcons';
import {colors} from '../constants/color';
import {iconSizes} from '../constants/dimensions';

const PlayerRepeatToggle = () => {
  return (
    <View>
      <TouchableOpacity>
        <MaterialCommunityIcons
          name={'repeat'}
          color={colors.iconSecondary}
          size={iconSizes.lg}
        />
      </TouchableOpacity>
    </View>
  );
};

export default PlayerRepeatToggle;

const styles = StyleSheet.create({});
