import {
  StyleSheet,
  Text,
  Touchable,
  TouchableOpacity,
  View,
  FlatList,
} from 'react-native';
import React from 'react';
import {colors} from '../constants/color';
import AntDesign from 'react-native-vector-icons/AntDesign';
import {fontSizes, iconSizes, spacing} from '../constants/dimensions';
import SimpleLineIcons from 'react-native-vector-icons/SimpleLineIcons';
import {fontFamilies} from '../constants/fonts';
import SongCard from '../components/SongCard';
import FloatingPlayer from '../components/FloatingPlayer';
import useLikeSongs from '../store/likeStore';
import {useNavigation} from '@react-navigation/native';

const LikeScreen = () => {
  const navigation = useNavigation();
  const {likedSongs, addToLiked} = useLikeSongs();

  const handleGoBack = () => {
    navigation.goBack();
  };
  return (
    <View style={styles.container}>
      <View style={styles.headerContainer}>
        <TouchableOpacity onPress={handleGoBack}>
          <AntDesign
            name={'arrowleft'}
            color={colors.iconPrimary}
            size={iconSizes.md}></AntDesign>
        </TouchableOpacity>

        <TouchableOpacity>
          <SimpleLineIcons
            name={'equalizer'}
            color={colors.iconPrimary}
            size={iconSizes.md}></SimpleLineIcons>
        </TouchableOpacity>
      </View>
      {/* rendering the list of liked songs */}
      <FlatList
        ListHeaderComponent={
          <Text style={styles.headingText}>Liked Songs</Text>
        }
        data={likedSongs}
        renderItem={({item}) => (
          <SongCard
            containerStyle={{width: '47%'}}
            imageStyle={{
              height: 160,
              width: 160,
            }}
            item={item}
          />
        )}
        numColumns={2}
        contentContainerStyle={{
          paddingBottom: '500',
          paddingHorizontal: spacing.lg,
        }}
        columnWrapperStyle={{
          justifyContent: 'space-between',
          marginVertical: spacing.sm,
        }}
      />
      <FloatingPlayer />
    </View>
  );
};

export default LikeScreen;

const styles = StyleSheet.create({
  container: {
    flex: 1,
    backgroundColor: colors.background,
  },
  headerContainer: {
    flexDirection: 'row',
    justifyContent: 'space-between',
    alignItems: 'center',
    paddingHorizontal: spacing.md,
    paddingVertical: spacing.md,
  },
  headingText: {
    fontSize: fontSizes.lg,
    color: colors.iconPrimary,
    fontFamily: fontFamilies.bold,
  },
});
