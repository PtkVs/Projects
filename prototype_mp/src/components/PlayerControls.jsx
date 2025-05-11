/********ORIGINAL CODE****** */
import {TouchableOpacity} from 'react-native';
import MaterialCommunityIcons from 'react-native-vector-icons/MaterialCommunityIcons';
import {iconSizes} from '../constants/dimensions';
import {colors} from '../constants/color';
import FontAwesome6 from 'react-native-vector-icons/FontAwesome6';
import {useIsPlaying} from 'react-native-track-player';
import TrackPlayer from 'react-native-track-player';

export const PreviousButton = ({size = iconSizes.xl}) => {
  const handleGoToPrevious = async () => {
    TrackPlayer.skipToPrevious();
  };
  return (
    <TouchableOpacity activeOpacity={0.7} onPress={handleGoToPrevious}>
      <MaterialCommunityIcons
        name={'skip-previous-outline'}
        size={size}
        color={colors.iconPrimary}
      />
    </TouchableOpacity>
  );
};

export const PlayPauseButton = ({size = iconSizes.xl}) => {
  const {playing} = useIsPlaying();

  const handleTogglePlay = () => {
    if (playing) {
      TrackPlayer.pause();
    } else {
      TrackPlayer.play();
    }
  };
  return (
    <TouchableOpacity activeOpacity={0.7} onPress={handleTogglePlay}>
      <FontAwesome6
        name={playing ? 'pause' : 'play'}
        size={size}
        color={colors.iconPrimary}
      />
    </TouchableOpacity>
  );
};

export const NextButton = ({size = iconSizes.xl}) => {
  const handleGoToNext = async () => {
    TrackPlayer.skipToNext();
  };
  return (
    <TouchableOpacity activeOpacity={0.7} onPress={handleGoToNext}>
      <MaterialCommunityIcons
        name={'skip-next-outline'}
        size={size}
        color={colors.iconPrimary}
      />
    </TouchableOpacity>
  );
};
