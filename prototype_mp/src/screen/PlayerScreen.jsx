import {Image, StyleSheet, Text, TouchableOpacity, View} from 'react-native';
import React, {useEffect, useState} from 'react';

import AntDesign from 'react-native-vector-icons/AntDesign';
import Feather from 'react-native-vector-icons/Feather';
import Entypo from 'react-native-vector-icons/Entypo';
import {colors} from '../constants/color';
import {fontSizes, iconSizes, spacing} from '../constants/dimensions';
import {fontFamilies} from '../constants/fonts';
import PlayerRepeatToggle from '../components/PlayerRepeatToggle';
import PlayerShuffleToggle from '../components/PlayerShuffleToggle';
import PlayerProgressBar from '../components/PlayerProgressBar';
import {
  NextButton,
  PlayPauseButton,
  PreviousButton,
} from '../components/PlayerControls';
import TrackPlayer, {useActiveTrack} from 'react-native-track-player';

import {playAmbientSound, stopAmbientSound} from '../data/ambientSounds';
import {Modal, Pressable} from 'react-native';
import useLikeSongs from '../store/likeStore';
import {useNavigation} from '@react-navigation/native';

const PlayerScreen = () => {
  //for using the active image of the playing
  const activeTrack = useActiveTrack();

  // Navigation hook to navigate back to the previous screen
  const navigation = useNavigation();
  const handleGoBack = () => {
    navigation.goBack();
  };

  //function  to check if the song is mute or not
  const [isMute, setIsMute] = useState(false);
  useEffect(() => {
    setVolume();
  }, []);
  const setVolume = async () => {
    const volume = await TrackPlayer.getVolume();
    setIsMute(volume === 0 ? true : false);
  };

  // State to manage the visibility of the ambient sound modal
  // This modal will allow users to select ambient sounds like rain, thunder, etc.
  const [isAmbientModalVisible, setIsAmbientModalVisible] = useState(false);

  const toggleAmbientModal = () => {
    setIsAmbientModalVisible(!isAmbientModalVisible);
  };

  // Function to handle toggling volume. This will set the volume to 0 when muted and to 1 when unmuted
  const handleToggleVolume = () => {
    TrackPlayer.setVolume(isMute ? 1 : 0);
    setIsMute(!isMute);
  };

  //Function for Like/Heart Button
  const {likedSongs, addToLiked} = useLikeSongs();
  const isLiked = likedSongs.some(song => song.id === activeTrack?.id);

  return (
    <View style={styles.maincontainer}>
      {/* Header */}
      <View style={styles.headerContainer}>
        <TouchableOpacity onPress={handleGoBack}>
          <AntDesign
            name={'arrowleft'}
            style={styles.arrowButton}
            color={colors.iconPrimary}
            size={iconSizes.lg}
          />
        </TouchableOpacity>
        <Text style={styles.headerText}>Playing Now</Text>
      </View>

      {/* Cover Image */}
      <View style={styles.coverImageContainer}>
        <Image
          source={{uri: activeTrack?.artwork}}
          style={styles.coverImage}></Image>
      </View>

      {/* Heart/Like Button, Atist and Ttle here */}
      <View style={styles.bodyContainer}>
        {/* Title and Artist */}
        <View style={styles.titleContainer}>
          <Text style={styles.songTitle}> {activeTrack?.title} </Text>
          <Text style={styles.artistName}> {activeTrack?.artist} </Text>
        </View>

        {/* Heart Button */}
        <TouchableOpacity onPress={() => addToLiked(activeTrack)}>
          <AntDesign
            name={isLiked ? 'heart' : 'hearto'}
            color={colors.iconSecondary}
            size={iconSizes.md}
          />
        </TouchableOpacity>
      </View>

      {/* player control options like shuffle, repeat and volume  */}
      <View style={styles.playerControlContainer}>
        {/*Volume Button */}
        <TouchableOpacity
          style={styles.volumeButton}
          onPress={handleToggleVolume}>
          <Feather
            name={isMute ? 'volume-x' : 'volume-1'}
            color={colors.iconSecondary}
            size={iconSizes.lg}
          />
        </TouchableOpacity>

        {/* Repeat and Shuffle Button */}
        <View style={styles.shuffleANDrepeatButton}>
          <PlayerRepeatToggle />
          <PlayerShuffleToggle />
        </View>
      </View>

      {/* Player Progress Bar */}
      <PlayerProgressBar />

      {/* Play and Pause Button */}
      <View style={styles.playPauseContainer}>
        <PreviousButton />
        <PlayPauseButton />
        <NextButton />
      </View>

      {/* Ambient Sound Button */}
      <TouchableOpacity
        style={styles.ambientSoundButton}
        onPress={toggleAmbientModal}>
        <Entypo
          name={'popup'}
          color={colors.iconSecondary}
          size={iconSizes.lg}
        />
      </TouchableOpacity>

      <Modal
        transparent={true}
        animationType="slide"
        visible={isAmbientModalVisible}
        onRequestClose={toggleAmbientModal}>
        <View style={styles.modalOverlay}>
          <View style={styles.modalContainer}>
            <Text style={styles.modalTitle}>Select Ambient Sound</Text>

            {['rain', 'thunder', 'rain2', 'fire'].map(sound => (
              <TouchableOpacity
                key={sound}
                style={styles.modalOption}
                onPress={() => {
                  playAmbientSound(sound);
                  toggleAmbientModal();
                }}>
                <Text>{sound.charAt(0).toUpperCase() + sound.slice(1)}</Text>
              </TouchableOpacity>
            ))}

            <TouchableOpacity
              onPress={() => {
                console.log('Stopping Ambient Sound');
                stopAmbientSound();
                toggleAmbientModal();
              }}>
              <Text style={styles.modalStop}>Stop Ambient Sound</Text>
            </TouchableOpacity>
          </View>
        </View>
      </Modal>
    </View>
  );
};

export default PlayerScreen;

const styles = StyleSheet.create({
  maincontainer: {
    flex: 1,
    backgroundColor: colors.background,
    padding: spacing.lg,
  },
  headerContainer: {
    flexDirection: 'row',
    alignItems: 'center',
    width: '100%',
  },
  headerText: {
    flex: 1,
    textAlign: 'center',
    color: colors.textPrimary,
    fontSize: fontSizes.xl,
    fontFamily: fontFamilies.medium,
  },
  coverImage: {
    width: 300,
    height: 400,
    borderRadius: 10,
  },
  coverImageContainer: {
    alignItems: 'center',
    justifyContent: 'center',
    marginVertical: spacing.lg,
  },

  bodyContainer: {
    flexDirection: 'row',
    alignItems: 'center',
  },
  titleContainer: {
    flex: 1,
    alignItems: 'center',
    justifyContent: 'center',
  },
  songTitle: {
    color: colors.textPrimary,
    fontSize: fontSizes.xl,
    fontFamily: fontFamilies.medium,
    textAlign: 'center',
  },
  artistName: {
    color: colors.textSecondary,
    fontSize: fontSizes.lg,
    fontFamily: fontFamilies.regular,
    textAlign: 'center',
  },
  playerControlContainer: {
    flexDirection: 'row',
    justifyContent: 'space-between',
    alignItems: 'center',
    marginVertical: spacing.xl,
  },

  volumeButton: {
    flex: 1,
  },
  shuffleANDrepeatButton: {
    flexDirection: 'row',
    gap: spacing.xl,
  },
  playPauseContainer: {
    flexDirection: 'row',
    justifyContent: 'center',
    alignItems: 'center',
    gap: spacing.xl,
    padding: spacing.xl,
  },
  ambientSoundButton: {
    position: 'absolute',
    bottom: spacing.xl,
    right: spacing.xl,
    borderRadius: 50,
    padding: spacing.xl,
    elevation: 5,
  },

  modalOverlay: {
    flex: 1,
    justifyContent: 'center',
    alignItems: 'center',
    backgroundColor: 'rgba(0, 0, 0, 0.5)', // translucent dark overlay
  },
  modalContainer: {
    backgroundColor: colors.background,
    padding: 20,
    borderRadius: 10,
    width: '80%',
    elevation: 10,
    shadowColor: '#000',
    shadowOffset: {width: 0, height: 2},
    shadowOpacity: 0.25,
    shadowRadius: 4,
  },
  modalTitle: {
    fontSize: 18,
    fontWeight: 'bold',
    marginBottom: 10,
    textAlign: 'center',
  },
  modalOption: {
    paddingVertical: 10,
  },
  modalStop: {
    color: 'red',
    marginTop: 20,
    textAlign: 'center',
  },
});
