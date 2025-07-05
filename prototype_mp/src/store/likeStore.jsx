import {create} from 'zustand';
import {isExist} from '../utils/timeindex';
import AsyncStorage from '@react-native-async-storage/async-storage';

const useLikeSongs = create(set => ({
  likedSongs: [],

  addToLiked: async newSong => {
    set(state => {
      const isAlreadyLiked = isExist(state.likedSongs, newSong);
      const updatedSongs = isAlreadyLiked
        ? state.likedSongs
        : [newSong, ...state.likedSongs];

      // Save to AsyncStorage
      AsyncStorage.setItem('likedSongs', JSON.stringify(updatedSongs)).catch(
        error => console.error('Error saving liked songs:', error),
      );

      return {
        likedSongs: updatedSongs,
      };
    });
  },

  loadLikedSongs: async () => {
    try {
      const storedSongs = await AsyncStorage.getItem('likedSongs');
      if (storedSongs) {
        set({likedSongs: JSON.parse(storedSongs)});
      }
    } catch (error) {
      console.error('Error loading liked songs:', error);
    }
  },
}));

export default useLikeSongs;
