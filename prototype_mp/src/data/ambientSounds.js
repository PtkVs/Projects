// utils/AmbientSoundPlayer.js
import Sound from 'react-native-sound';

let currentAmbientSound = null;

export const playAmbientSound = soundName => {
  if (currentAmbientSound) {
    currentAmbientSound.stop();
    currentAmbientSound.release();
  }

  const sound = new Sound(`${soundName}.mp3`, Sound.MAIN_BUNDLE, error => {
    if (error) {
      console.log('Failed to load sound', error);
      return;
    }
    sound.setNumberOfLoops(-1); // Loop infinitely
    sound.setVolume(0.3); // Low volume
    sound.play();
  });

  currentAmbientSound = sound;
};

export const stopAmbientSound = () => {
  if (currentAmbientSound) {
    currentAmbientSound.stop();
    currentAmbientSound.release();
    currentAmbientSound = null;
  }
};
