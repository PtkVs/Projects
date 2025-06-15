import TrackPlayer from 'react-native-track-player';
import {useEffect, useCallback, useState} from 'react';

export const useTrackPlayerRepeatMode = () => {
  const [repeatMode, setRepeatMode] = useState(null);
  const changeRepeatMode = useCallback(async repeatMode => {
    await TrackPlayer.setRepeatMode(repeatMode);
    setRepeatMode(repeatMode);
  }, []);

  useEffect(() => {
    TrackPlayer.getRepeatMode().then(setRepeatMode);
  }, []);

  return {
    repeatMode,
    changeRepeatMode,
  };
};
