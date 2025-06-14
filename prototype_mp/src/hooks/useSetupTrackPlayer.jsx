import {useEffect, useRef} from 'react';
import TrackPlayer, {RepeatMode} from 'react-native-track-player';
import {Capability, RatingType} from 'react-native-track-player';

const setupPlayer = async () => {
  await TrackPlayer.setupPlayer({
    maxCacheSize: 1024 * 10,
  });
  //yo capabilities haru chai locked screen ma bar ma dekhauna use hunxa i.e play pause etc  when you lock the screen
  await TrackPlayer.updateOptions({
    ratingType: RatingType.Heart,
    capabilities: [
      Capability.Play,
      Capability.Pause,
      Capability.SkipToNext,
      Capability.SkipToPrevious,
      Capability.Stop,
    ],
    //yo chai for notification bar ma dekhauna use hunxa, kun kun icon haru dekhaune vanda play pause etc
    compactCapabilities: [
      Capability.Play,
      Capability.Pause,
      Capability.SkipToNext,
      Capability.SkipToPrevious,
    ],
  });
  //by default when song is played kati volue hunxa
  await TrackPlayer.setVolume(0.5);
  await TrackPlayer.setRepeatMode(RepeatMode.Queue);
};

export const useSetupTrackPlayer = ({onLoad}) => {
  const inInitialized = useRef(false);
  useEffect(() => {
    setupPlayer()
      .then(() => {
        inInitialized.current = true;
        onLoad();
      })
      .catch(error => {
        isInitialized.current = false;
        console.log('Error setting up TrackPlayer:', error);
      });
  }, []);
};
