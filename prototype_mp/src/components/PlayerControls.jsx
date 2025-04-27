import {TouchableOpacity} from 'react-native';
import MaterialCommunityIcons from 'react-native-vector-icons/MaterialCommunityIcons';
import {iconSizes} from '../constants/dimensions';
import {colors} from '../constants/color';
import FontAwesome6 from 'react-native-vector-icons/FontAwesome6';

export const PreviousButton = ({size = iconSizes.xl}) => {
  return (
    <TouchableOpacity activeOpacity={0.7}>
      <MaterialCommunityIcons
        name={'skip-previous-outline'}
        size={size}
        color={colors.iconPrimary}
      />
    </TouchableOpacity>
  );
};

export const PlayPauseButton = ({isPlaying = true, size = iconSizes.xl}) => {
  return (
    <TouchableOpacity>
      <FontAwesome6
        name={isPlaying ? 'play' : 'pause'}
        size={size}
        color={colors.iconPrimary}
      />
    </TouchableOpacity>
  );
};

export const NextButton = ({size = iconSizes.xl}) => {
  return (
    <TouchableOpacity activeOpacity={0.7}>
      <MaterialCommunityIcons
        name={'skip-next-outline'}
        size={size}
        color={colors.iconPrimary}
      />
    </TouchableOpacity>
  );
};
