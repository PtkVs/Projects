import {create} from 'zustand';

const useLikeSongs = create(set => ({
  likedSongs: [],
  addToLiked: newSong => {
    set(state => {
      return {
        likedSongs: [newSong, ...state.likedSongs],
      };
    });
  },
}));

export default useLikeSongs;
