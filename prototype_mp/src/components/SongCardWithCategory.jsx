import {FlatList, StyleSheet, Text, View} from 'react-native';
import React from 'react';
import {spacing} from '../constants/dimensions';
import SongCard from './SongCard';
import {colors} from '../constants/color';
import {fontFamilies} from '../constants/fonts';
import {fontSizes} from '../constants/dimensions';
import TrackPlayer from 'react-native-track-player';

// SongCardWithCategory component to display a list of songs in a category dynamically like recommended songs, new releases, etc. and songs images
const SongCardWithCategory = ({item}) => {
  //function created to play a song in que
  const handlePlayTrack = async (selectedTrack, songs = item.songs) => {
    // making a que and play the songs
    const trackIndex = songs.findIndex(
      track => track.url === selectedTrack.url,
    );

    //if track does not exist in the array
    if (trackIndex === -1) {
      return;
    }

    //logic behind queing and playing  the songs
    const beforeTracks = songs.slice(0, trackIndex);
    const afterTracks = songs.slice(trackIndex + 1);
    await TrackPlayer.reset();
    await TrackPlayer.stop();
    await TrackPlayer.add(selectedTrack);
    await TrackPlayer.add(afterTracks);
    await TrackPlayer.add(beforeTracks);
    await TrackPlayer.play();
  };

  return (
    <View style={styles.container}>
      <Text style={styles.headingText}> {item.title}</Text>

      {/* flat list le  scrollview/ feature ko lagi use hunxa */}
      {/* Yo flatlist is  horizontal(child container) rendering component inside of main vertical(parent container) */}

      <FlatList
        data={item.songs}
        renderItem={({item}) => (
          <SongCard
            item={item}
            handlePlay={selectedTrack => {
              handlePlayTrack(selectedTrack, item.songs);
            }}></SongCard>
        )}
        horizontal={true}
        ItemSeparatorComponent={() => <View style={{marginHorizontal: 10}} />}
        contentContainerStyle={{paddingHorizontal: spacing.md}}
      />
    </View>
  );
};

export default SongCardWithCategory;

const styles = StyleSheet.create({
  container: {
    flex: 1,
  },

  headingText: {
    fontSize: fontSizes.lg,
    color: colors.textPrimary,
    fontFamily: fontFamilies.bold,
    paddingVertical: spacing.md,
    paddingHorizontal: spacing.md,
  },
});
