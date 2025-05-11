import {StyleSheet, Text, TouchableOpacity, View} from 'react-native';
import React from 'react';
import {
  DrawerContentScrollView,
  DrawerItemList,
} from '@react-navigation/drawer';
import {colors} from '../constants/color';
import {iconSizes, spacing} from '../constants/dimensions';
import AntDesign from 'react-native-vector-icons/AntDesign';
import Octicons from 'react-native-vector-icons/Octicons';
import FontAwesome from 'react-native-vector-icons/FontAwesome';
import {DrawerItem} from '@react-navigation/drawer';
import {fontFamilies} from '../constants/fonts';

import LikeScreen from '../screen/LikeScreen';

const CustomDrawerContent = props => {
  const isDarkMode = true;
  const toggleDrawer = () => {
    props.navigation.toggleDrawer();
  };

  return (
    <DrawerContentScrollView style={styles.mainContainer}>
      {/* Header Items */}
      <View style={styles.headerIconContainer}>
        {/*Close Icon */}
        <TouchableOpacity onPress={toggleDrawer}>
          <AntDesign
            name={'close'}
            color={colors.iconPrimary}
            size={iconSizes.md}
          />
        </TouchableOpacity>

        {/* Moon Icon */}
        <TouchableOpacity>
          <Octicons
            name={isDarkMode ? 'sun' : 'moon'}
            color={colors.iconPrimary}
            size={iconSizes.md}
          />
        </TouchableOpacity>
      </View>

      {/* Menu Items */}
      <View style={styles.menuIconContainer}>
        {/* Drawer item Profile icon and label  */}
        <DrawerItem
          style={styles.profileDrawerItemContainer}
          label={'Profile'}
          labelStyle={styles.labelStyle}
          icon={() => (
            <FontAwesome
              name="user"
              size={iconSizes.md}
              color={colors.iconSecondary}
            />
          )}
        />

        {/* Drawer item Liked Songs icon and label  */}
        <DrawerItem
          style={styles.likedDrawerItemContainer}
          label={'Liked Songs'}
          labelStyle={styles.labelStyle}
          icon={() => (
            <AntDesign
              name="hearto"
              size={iconSizes.md}
              color={colors.iconSecondary}
            />
          )}
          onPress={() => {
            props.navigation.navigate('DRAWER_HOME', {screen: 'LIKE_SCREEN'});
          }}
        />

        {/* Drawer item Language icon and label  */}
        <DrawerItem
          style={styles.languageDrawerItemContainer}
          label={'Language'}
          labelStyle={styles.labelStyle}
          icon={() => (
            <FontAwesome
              name="language"
              size={iconSizes.md}
              color={colors.iconSecondary}
            />
          )}
          onPress={() => {
            props.navigation.navigate('DRAWER_HOME', {screen: 'LIKE_SCREEN'});
          }}
        />

        {/* Drawer item Contact icon and label  */}
        <DrawerItem
          style={styles.contactDrawerItemContainer}
          label={'Contact Us'}
          labelStyle={styles.labelStyle}
          icon={() => (
            <FontAwesome
              name="envelope-o"
              size={iconSizes.md}
              color={colors.iconSecondary}
            />
          )}
          onPress={() => {
            props.navigation.navigate('DRAWER_HOME', {screen: 'LIKE_SCREEN'});
          }}
        />

        {/* Drawer item FAQ Contact icon and label  */}
        <DrawerItem
          style={styles.faqDrawerItemContainer}
          label={'FAQs'}
          labelStyle={styles.labelStyle}
          icon={() => (
            <FontAwesome
              name="question-circle-o"
              size={iconSizes.md}
              color={colors.iconSecondary}
            />
          )}
          onPress={() => {
            props.navigation.navigate('DRAWER_HOME', {screen: 'LIKE_SCREEN'});
          }}
        />

        {/* Drawer Item Settings icon and label  */}
        <DrawerItem
          style={styles.settingsDrawerItemContainer}
          label={'Settings'}
          labelStyle={styles.labelStyle}
          icon={() => (
            <FontAwesome
              name="cog"
              size={iconSizes.md}
              color={colors.iconSecondary}
            />
          )}
          onPress={() => {
            props.navigation.navigate('DRAWER_HOME', {screen: 'LIKE_SCREEN'});
          }}
        />
      </View>
    </DrawerContentScrollView>
  );
};

export default CustomDrawerContent;

const styles = StyleSheet.create({
  mainContainer: {
    backgroundColor: colors.background,
    padding: spacing.lg,
  },
  headerIconContainer: {
    flexDirection: 'row',
    justifyContent: 'space-between',
    alignItems: 'center',
  },
  profileDrawerItemContainer: {
    marginVertical: spacing.sm,
  },
  labelStyle: {
    color: colors.iconPrimary,
    fontSize: iconSizes.md,
    fontFamily: fontFamilies.medium,
  },
  likedDrawerItemContainer: {
    marginVertical: spacing.sm,
  },
  languageDrawerItemContainer: {
    marginVertical: spacing.sm,
  },
  contactDrawerItemContainer: {
    marginVertical: spacing.sm,
  },
  faqDrawerItemContainer: {
    marginVertical: spacing.sm,
  },
  settingsDrawerItemContainer: {
    marginVertical: spacing.sm,
  },
});
