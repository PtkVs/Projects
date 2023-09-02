-- phpMyAdmin SQL Dump
-- version 3.5.2
-- http://www.phpmyadmin.net
--
-- Host: localhost
-- Generation Time: Jan 19, 2016 at 07:07 AM
-- Server version: 5.5.25a
-- PHP Version: 5.4.4

SET SQL_MODE="NO_AUTO_VALUE_ON_ZERO";
SET time_zone = "+00:00";


/*!40101 SET @OLD_CHARACTER_SET_CLIENT=@@CHARACTER_SET_CLIENT */;
/*!40101 SET @OLD_CHARACTER_SET_RESULTS=@@CHARACTER_SET_RESULTS */;
/*!40101 SET @OLD_COLLATION_CONNECTION=@@COLLATION_CONNECTION */;
/*!40101 SET NAMES utf8 */;

--
-- Database: `gnp`
--

-- --------------------------------------------------------

--
-- Table structure for table `table_aboutus`
--

CREATE TABLE IF NOT EXISTS `table_aboutus` (
  `AboutUsID` int(50) NOT NULL AUTO_INCREMENT,
  `AboutUs` mediumtext NOT NULL,
  PRIMARY KEY (`AboutUsID`)
) ENGINE=InnoDB  DEFAULT CHARSET=utf8 AUTO_INCREMENT=2 ;

--
-- Dumping data for table `table_aboutus`
--

INSERT INTO `table_aboutus` (`AboutUsID`, `AboutUs`) VALUES
(1, '\r\n\r\n\r\n\r\n\r\nThis is the copyright network of Pratik and Co. Limited Developed by Pratik Baishnav. This site is develeped for the partial fulfillment of the requirement for the award of the degree of B.Sc.IT Third Semester of SIKKIM MANIAPAL UNIVERSITY (SMU) . This project is carefully verified and found the report to be original work of the student and written according to the prescribed format of the University. We recommend the report to be accepted as partial fulfillment of the requirements for the B.Sc.IT Third semester.\r\n');

-- --------------------------------------------------------

--
-- Table structure for table `table_category`
--

CREATE TABLE IF NOT EXISTS `table_category` (
  `CategoryID` int(50) NOT NULL AUTO_INCREMENT,
  `Category Name` varchar(50) NOT NULL,
  PRIMARY KEY (`CategoryID`)
) ENGINE=InnoDB  DEFAULT CHARSET=utf8 AUTO_INCREMENT=5 ;

--
-- Dumping data for table `table_category`
--

INSERT INTO `table_category` (`CategoryID`, `Category Name`) VALUES
(1, 'Carry'),
(2, 'Nuker'),
(3, 'Tank'),
(4, 'Support');

-- --------------------------------------------------------

--
-- Table structure for table `table_help`
--

CREATE TABLE IF NOT EXISTS `table_help` (
  `HelpID` int(11) NOT NULL AUTO_INCREMENT,
  `Help` mediumtext NOT NULL,
  PRIMARY KEY (`HelpID`)
) ENGINE=InnoDB  DEFAULT CHARSET=utf8 AUTO_INCREMENT=2 ;

--
-- Dumping data for table `table_help`
--

INSERT INTO `table_help` (`HelpID`, `Help`) VALUES
(1, 'Hi! \r\n* Please go to the Watch all News tab for viewing all the latest news of the site.You can enjoy        our latest news on this tab.\r\n\r\n* If you want to change you details i.e Password pleases go to the *Self Details tab for changing your password.\r\n\r\n* If you want to have full access of our site i.e want to view all the latest news and information you must be a member of this site.\r\n\r\n* Full news cannot be accessed or viewed by the visitors i.e without being a member of this site users are not allowed to have the access of our information of the site freely.\r\n\r\n* If you have any problem or any difficulties please contact our administrator on this contact\r\nnumber : 9849263626/9801056706 or you can email @ ptk_vs@yahoo.com\r\n\r\n ');

-- --------------------------------------------------------

--
-- Table structure for table `table_log`
--

CREATE TABLE IF NOT EXISTS `table_log` (
  `LogID` int(50) NOT NULL AUTO_INCREMENT,
  `UserID` int(50) NOT NULL,
  `LogInTime` varchar(50) NOT NULL,
  `LogOutTime` varchar(50) NOT NULL,
  PRIMARY KEY (`LogID`)
) ENGINE=InnoDB  DEFAULT CHARSET=utf8 AUTO_INCREMENT=10 ;

--
-- Dumping data for table `table_log`
--

INSERT INTO `table_log` (`LogID`, `UserID`, `LogInTime`, `LogOutTime`) VALUES
(1, 1, '2016-01-18 16:34:21', '2016-01-18 16:34:29'),
(2, 1, '2016-01-18 16:35:18', '2016-01-18 16:35:40'),
(3, 1, '2016-01-18 16:38:37', '2016-01-18 16:39:06'),
(4, 1, '2016-01-18 16:44:37', '2016-01-18 17:58:03'),
(5, 1, '2016-01-18 17:58:17', '2016-01-18 18:29:39'),
(6, 1, '2016-01-18 20:37:56', '2016-01-18 22:13:38'),
(7, 1, '2016-01-18 22:14:42', '2016-01-18 22:15:36'),
(8, 1, '2016-01-18 22:36:44', '2016-01-18 23:17:15'),
(9, 1, '2016-01-18 23:49:25', '2016-01-18 23:49:47');

-- --------------------------------------------------------

--
-- Table structure for table `table_news`
--

CREATE TABLE IF NOT EXISTS `table_news` (
  `NewsID` int(11) NOT NULL AUTO_INCREMENT,
  `Title` varchar(50) NOT NULL,
  `Category` varchar(50) NOT NULL,
  `Description` mediumtext NOT NULL,
  `CreatedBy` varchar(50) NOT NULL,
  `CreatedDate` varchar(50) NOT NULL,
  `ModifiedBy` varchar(50) NOT NULL,
  `ModifiedDate` varchar(50) NOT NULL,
  `ImageName` varchar(200) NOT NULL,
  PRIMARY KEY (`NewsID`)
) ENGINE=InnoDB  DEFAULT CHARSET=utf8 AUTO_INCREMENT=21 ;

--
-- Dumping data for table `table_news`
--

INSERT INTO `table_news` (`NewsID`, `Title`, `Category`, `Description`, `CreatedBy`, `CreatedDate`, `ModifiedBy`, `ModifiedDate`, `ImageName`) VALUES
(1, 'Phantom Assassin', 'Carry', 'Mortred the Phantom Assassin is a melee agility Hero fitting the role of hard carry. Mortred is best-known, and infamous for, her ability to inflict staggering damage with single strikes. Her abilities synergise supremely well with each other, rendering her an extremely formidable foe once she has acquired the items she requires. She is a very farm-dependent melee Hero, but she farms creeps with much more ease than many of her fellow carries, using her Stifling Dagger for last hitting. Besides eliminating the weakness most melee Heroes have in their farming, it also saves her from expending gold on important melee carry items like Quelling Blade. Her second ability, Phantom Strike, acts as both her escape and initiate, while Blur gives her an edge against other Heroes that depend on their physical attacks by evading them; giving her partial damage immunity to many carries. Her ultimate, the strongest critical strike in the game, is what connects Mortred with four-digit damage and what gives her a place amongst the very best support killers in the late game, since they usually fall instantly from the divine strike her ultimate provides. Mobile and able to fight back nearly every enemy that dares to face her, Mortred is a formidable foe that should never be underestimated, ever and with appropriate item choices and a few kills, she can snowball out of control and become next to impossible to stop.', 'admin', '2016-01-18 22:39:50', 'Admin', '2016-01-18 22:59:09', 'Phantom_Assassin.png'),
(2, 'Crystal Maiden', 'Support', 'Rylai the Crystal Maiden is a ranged intelligence Hero used as a hard support and disabler. She is perhaps best known for her powerful global mana regeneration aura. This aura allows mana dependent allies to excel during the early to mid game and the laning phase, and allows her to constantly activate her own spells without needing to worry much about the mana costs. She also has a high amount of early game presence with just a few points in her Crystal Nova and Frostbite abilities. Crystal Nova is a powerful area-of-effect nuke that slows both attack and movement speeds of enemies within an area for several seconds, while Frostbite encases an enemy in a block of ice for several seconds, immobilizing it and doing moderate damage per second. Combining these two abilities together along with a laning partner s own spells often results in the quick death of an enemy hero. Although her strong early game presence is quickly lost due to her extreme frailty and poor mobility, she can still inflict a heavy amount of damage in teamfights later on if she is able to channel her deadly ultimate, Freezing Field. Her Arcane Aura, strong disabling and nuking prowess, relative ease of usage, and almost complete lack of item dependence makes her a reliable support caster that can be useful in any team, and the rare aspect of her ultimate remaining incredibly deadly even in very late stages of the game makes her one of the best scaling supports in the entire game. With protection from her team and appropriate item selection, she can be the only true support any team needs.', 'admin', '2016-01-18 22:42:03', 'null', 'null', 'Crystal_Maiden.png'),
(3, 'Axe', 'Tank', 'Mogul Khan, the Axe, is a melee strength hero, infamous for creating chaos in battle and thriving off of it.Axe is commonly played as an initiator, as his potent disables can disrupt the enemy s formation and give his team openings in fights. Axe s fighting style demands that he gets up close and very personal, as he can taunt enemies into attacking him with Berserker s Call, preventing them from engaging his teammates. Once he has the enemy s attention, he can counter those who strike him with a sweeping Counter Helix that slashes all enemies at melee range with Physical damage. He also has a slow and damage-over-time nuke in Battle Hunger, which can harass the enemy or force them to join in battle, while also slowing their movement speed and boosting his own. Finally, he has the ability to unconditionally remove weakened enemies from the battlefield if they are under a certain threshold with Culling Blade, while simultaneously boosting his allies  speed. A bloodthirsty and indomitable warrior, Axe s presence on the battlefield is felt by friend and foe alike, dominating the attention of the enemy wherever he goes.\r\n', 'admin', '2016-01-18 22:45:06', 'null', 'null', 'Axe.png'),
(4, 'Queen Of Pain', 'Nuker', 'Akasha the Queen of Pain is a ranged intelligence hero who uses her abilities to close in and deal huge area damage to the enemy. She is typically played as a ganker with her ability to appear in battle and deal damage in quick succession, as well as hunt down fleeing heroes with ease. Her Blink ability is the lynchpin of her skill set, allowing her to enter and leave fights at her whim. Once in position to attack, Akasha can unleash her Scream of Pain and Sonic Wave, able to devastate an entire team at once. Chasing down straggling prey is another of her fortes, with Shadow Strike crippling their ability to escape. Akasha is very adept at getting kills early in the game, and transitions very well into a semi-carry if she acquires the proper items.', 'admin', '2016-01-18 22:45:39', 'null', 'null', 'Queen_of_Pain.png'),
(5, 'Anti Mage', 'Carry', 'Anti-Mage is a fast melee Agility Carry with an emphasis on disabling and killing high-mana enemies. He has notably high agility and low base attack time, giving him high damage and scaling with his basic attacks. His signature ability is Mana Break, a passive attack modifier that makes him a huge threat to mana-reliant heroes, mainly Intelligence-based casters. In addition to granting substantial bonus damage on each attacks, its mana burn sets enemies up to be devastated by his ultimate ability, Mana Void. Blink is a highly versatile ability that allows Anti-Mage to instantly teleport short distances, thereby allowing him to escape, chase, and even farm with ease. Combined with his high base movement speed, this makes Anti-Mage a highly mobile hero at all points in the game. Spell Shield greatly increases Anti-Mage s magic resistance, allowing him to sustain more damage from enemy casters. Finally, Mana Void finishes off targets after their mana has been burnt, inflicting heavy damage to both the target and enemies surrounding the target. The damage Mana Void can potentially deal scales extremely well into the late game, as enemies mana pools only grow larger over time. His naturally fast basic attacks combined with his powerful abilities make him extremely dangerous in the late game, allowing him to devastate enemies with ease if he is allowed to farm as a hard carry.', 'admin', '2016-01-18 22:46:20', 'null', 'null', 'Anti-Mage.png'),
(6, 'Lion', 'Support', 'Lion the Demon Witch is a ranged intelligence hero who is adept at disabling and nuking his enemies, as well as being a strong lane support. Although his abilities do not scale into the lategame, his offensive power can destroy enemies during the early game and remain useful throughout the game, though more so to very fragile heroes than others.Lion is famous for his outstanding ability combos, making him a solid and versatile choice in any team composition. He has the ability to drain mana from enemy heroes with his Mana Drain ability and his complement of disables makes him an effective team-fighter and support in any stage of the game.', 'admin', '2016-01-18 22:47:12', 'null', 'null', 'Lion.png'),
(7, 'Warlock', 'Support', 'Demnok Lannik the Warlock is a ranged intelligence hero who possesses many powerful teamfight spells capable of inflicting chaos upon the enemy team. Shadow Word is a highly versatile spell, as it allows him to support allies by healing them or harass enemies by dealing damage over time, giving him strong lane presence. Beyond the early game, Warlock can turn any teamfight in his team s favor as his other spells are strong when unleashed against multiple enemies. Fatal Bonds causes all enemies linked together to take bonus damage when one of their number takes damage, magnifying the strength of area-of-effect spells, while Upheaval can allow him to greatly slow any enemies caught in the radius of the spell, making it harder for them to maneuver in fights or escape. His ultimate, Chaotic Offering, summons a Golem after stunning all enemies in a wide area, allowing him to throw them into disarray. While unassuming and weak by himself, Warlock is a dangerous threat in any teamfight as his spells allow him to turn the enemies  numbers against them and sow chaos amongst their ranks.', 'admin', '2016-01-18 22:47:44', 'null', 'null', 'Warlock.png'),
(8, 'Bristleback', 'Tank', 'Rigwarl the Bristleback is a melee strength hero famous for his array of synergistic spells with low mana cost and cooldown. He is able to slow his enemies down and reduce their armor with Viscous Nasal Goo, then hit them with a barrage of Quill Sprays, making him an effective chaser when ganking enemies. His low strength gain makes him less tanky than most strength heroes, but he becomes substantially more durable when he turns around due to his passive Bristleback, which reduces damage taken from behind. In the right hands, Bristleback is a powerful ganker in the early stages of the game, and a powerful hard carry in the later stages depending on how much farm he gets.', 'admin', '2016-01-18 22:48:10', 'null', 'null', 'Bristleback.png'),
(9, 'Earthshaker', 'Nuker', 'Raigor Stonehoof the Earthshaker is a melee strength hero with several area of effect disables, commonly played as a ganker or initiator. Unlike most strength heroes, he is played more like an intelligence caster hero and is almost entirely reliant on his spells to inflict heavy damage. His Fissure is a versatile spell that affects enemies in a line, used to stun, inflict decent damage, and create an impassable wall of earth for a significant duration. Good usage of this can cut off chokepoints, leaving enemies with no escape routes or preventing them from chasing after endangered allies. Enchant Totem massively boosts his attack damage for one attack, and has a very short cooldown. Aftershock lets the Earthshaker deal additional damage and stun in a small area around him everytime he uses one of his spells, and combos particularly well with Enchant Totem. Earthshaker s heavy AoE-centric kit is most powerful when his enemies are in large numbers and in close proximity. With his Echo Slam, he can deal heavy damage to clusters of enemies. All of Earthshaker s spells (with the exception of his ultimate) have a long casting animation, but with proper positioning, an adept Earthshaker can wreak havoc with his area-of-effect spells. Blink Dagger is an essential item for Earthshaker to be able to properly land Echo Slam within a cluster of enemies. At the same time, because of the high mana costs of his spells, he needs some form of mana sustenance. With his tremendous seismic power, the Earthshaker is never one that should be taken lightly even when he is heavily outnumbered.', 'admin', '2016-01-18 22:48:37', 'null', 'null', 'Earthshaker.png'),
(10, 'Death Prophet', 'Support', 'Krobelus the Death Prophet is a ranged intelligence Hero who excels at pushing lanes. She is often played in the mid lane, since her Crypt Swarm gives her strong magic damage that can be spammed to her heart s content. As she levels her ultimate, Exorcism, Death Prophet can deal a huge amount of damage to towers and heroes alike, while healing at the end of the duration. If Exorcism s own heal isn t enough, she still has Spirit Siphon which drains health based on the target s health and can even be used on multiple targets at the same time. Finally, her Silence gives her a powerful tool to disable enemy casters and heroes that rely on escape abilities. Because she can deal large amounts of damage over time with her ultimate and Crypt Swarm, Death Prophet is mostly built as a tank, to ensure she can continue to stay in the fight.', 'admin', '2016-01-18 22:49:26', 'null', 'null', 'Death_Prophet.png'),
(11, 'Abaddon', 'Tank', 'Abaddon the Lord of Avernus is a melee strength Hero known as one of the most versatile characters in Dota due to his rather low mana dependence, short spell cooldowns and a large number of viable item choices. His ability to help sustain his allies and himself plus his strong tower diving capacity give him solid lane presence. Many of his abilities offer a large sum of utility, which makes him a strong support Hero. Mist Coil serves as both a single target nuke and heal that helps shift the sustainability of both allied and enemy heroes in a lane at his will, though sacrificing a portion of his own health. Aphotic Shield holds as one of the most useful abilities in the game, able to shield a target from some damage while also able to reflect said damage to a huge area. The most important aspect is how it is able to dispel many status effects such as slows and stuns. His other abilities allow him to become a mix between a semi-carry and tank. Abaddon s passive, Curse of Avernus, allows his attacks to not only slow down his enemy, but also increase the attack and movement speed of any ally attacking the same target. With his ultimate, Borrowed Time, Abaddon is able to shift all non-HP removal damage he receives into health. When not on cooldown, Borrowed Time may activate passively when his health falls under a certain threshold, even under the most dire situations. Due to his powerful spells and versatility, Abaddon is an excellent addition to any team.', 'admin', '2016-01-18 22:50:06', 'null', 'null', 'Abaddon.png'),
(12, 'Medusa', 'Nuker', 'Medusa the Gorgon is a ranged agility Hero. Highly item-dependent, she acts as a carry who can potentially strike down entire teams at once while protected by tank-like survivability. Split Shot allows her attacks to hit multiple targets, greatly increasing the potency of damage-granting items. Mystic Snake grants Medusa some presence in the lane and skirmishes, and its mana stealing refunds part of the cost to boot, making it an excellent farming and harrassing tool. Mana Shield protects her from the opening damage of teamfights, and if supplemented with items makes killing Medusa a fatally time-consuming process. Stone Gaze acts as a fantastic defensive mechanism against ganks and initiations alike, with crippling effects on all who dare face the Gorgon.', 'admin', '2016-01-18 22:50:35', 'null', 'null', 'Medusa.png'),
(13, 'Riki', 'Carry', 'Riki the Stealth Assassin is a melee agility hero that uses stealth in order to surprise enemies and quickly kill them. His trademark ability, Cloak and Dagger, lets him sneak up on his enemies from behind and deal massive backstab damage, then quickly escape. This enables him to close in on the enemy and drop his devastating Smoke Screen, which cripples fighter and spellcaster alike. Blink Strike allows Riki to chase with impunity, while Tricks of the Trade makes quick work of his enemies during teamfights.', 'admin', '2016-01-18 22:51:06', 'null', 'null', 'Riki.png'),
(14, 'Witch Doctor', 'Support', 'Zharvakko the Witch Doctor is a ranged intelligence Hero who can take on the role of a support or a ganker. A master of voodoo curses and healing arts, he possesses several positioning-dependent crowd control/damage spells as well as a heal that scales well into the late game. Maledict is one of the most powerful damaging spells in the game, and is fittingly enough quite hard to hit properly - but when applied at the right time, Malediction can curse someone to suffer a slow, humiliating death as they limp back towards safety. Paralyzing Cask is a somewhat-unreliable stun that requires multiple enemies to bounce between to be effective, but can provide a barrage of stuns to the enemy team if they are grouped together. Death Ward has the potential to be one of the most damaging ultimates in the game so long as he is able to channel the spell uninterrupted.', 'admin', '2016-01-18 22:51:42', 'null', 'null', 'Witch_Doctor.png'),
(15, 'Undying', 'Tank', 'Undying the Almighty Dirge is a melee Strength Hero who serves as a formidable tank and a dangerous spellcaster. His abilities force opponents to either kill him or suffer powerful debuffs in a teamfight. Decay is a spammable ability that steals enemies  Strength in an area, making them more fragile and Undying himself more durable as the fight goes on while also being exceptionally potent during the early laning phase, leaving your opponents with mere scraps of health. Soul Rip can act as both a powerful heal or nuke, redirecting the flow of living energy to a target. By ripping some of the health of his ally or enemy in an area, the target can be healed if an ally, or damaged if an enemy. This is empowered by Tombstone, which acts as a static tank by summoning Zombies to slow Undying s foes while active. With the Zombies summoned, Soul Rip can perform to its fullest, while Decay weakens Undying s foes. Finally, Undying can transform into a horrific Flesh Golem. This transformation increases all allied damage by a significant percentage, and helps keep him alive as his team kills the enemy. Monstrous and truly sadomasochistic, Undying finds great pleasure in keeping himself alive and vital, while his adversaries suffer as he delivers death to the field. With powerful abilities that allow him to perform well in large fights, the Dirge may never cease.', 'admin', '2016-01-18 22:52:13', 'null', 'null', 'Undying.png'),
(16, 'Sven', 'Nuker', 'Sven the Rogue Knight is a versatile melee strength hero with superior physical power yet is coupled with various abilities that provide utility. He can fulfill various roles, but is often played as a semi-carry due to his high utility even without items. He possesses a versatile arsenal, from shouts that grant armor both for escaping and pushing to throwable gauntlets that disorient enemies around the target unit. With enough items, Sven has the potential to be a strong late-game carry due to his ultimate which increases his damage making him up to three times as powerful, which then can be used in conjunction with his Great Cleave in order to deal extraordinary cleave damage which can frequently lead to multiple kills with just a few swings from his sword. This immense power granted to him solely by his ultimate makes one of strongest late-game carries in the game, and arguably the strongest semi-carry of all, as his killing presence is able to stay up even if he decided to build more supportive/tanky/utility items. A truly frightening enemy to go up against if farmed, strong and versatile, Sven is a solid addition to almost every team composition.', 'admin', '2016-01-18 22:52:42', 'null', 'null', 'Sven.png'),
(17, 'Faceless Void', 'Carry', 'Darkterror the Faceless Void is a melee agility hard carry hero. Given a little time, he becomes a terrifyingly powerful hero capable of destroying entire enemy teams in seconds.Wielding his cosmically powered mace, each hit can lock his foes in time, stopping them in place. He can jump into or out of combat using Time Walk while simulatneously reverting recently taken damage. Darkterror can also pause his foes  cooldowns with Time Dilation, lowering their attack and movement speed in the process. His ultimate, Chronosphere, locks time for everything within its area of effect, giving him time to strike down any enemies caught within with no resistance from them for several seconds. Faceless Void is a hard carry and, as such, scales heavily from items and reaches his full potential in late game, growing into one of the most powerful and destructive Heroes in the game making him almost impossible to stop.', 'admin', '2016-01-18 22:53:15', 'null', 'null', 'Faceless_Void.png'),
(18, 'Centaur Warrunner', 'Tank', 'Bradwarden the Centaur Warrunner is a melee strength hero whose natural place in combat is right in the center of battle. His abilities stop enemies around him in their tracks and inflict heavy damage, making him an excellent initiator. He is also a powerful tank, having the highest strength gain in the game.Bradwarden has immense natural health, and his skills  area of effect mean that he can charge into combat and incapacitate groups of enemies at a time. Hoof Stomp and Double Edge make a great combo of stunning and burst damage on short cooldowns and his Return means instant retaliation on enemies who try attack him. His ultimate, Stampede effectively turns the entire team into initiators, granting them high speed and the ability to flatten enemies under as they pass over them.Although he is usually not played as a carry, he can scale powerfully with items, becoming a hard-hitting semi-carry that is nearly impossible to kill.\r\n', 'admin', '2016-01-18 22:53:59', 'null', 'null', 'Centaur_Warrunner.png'),
(19, 'Invoker', 'Nuker', 'Invoker is a ranged intelligence hero who is very difficult to master. He is unique in that he possesses a total of 14 abilities in his arsenal; three of them - Quas, Wex, and Exort - are reagents and one is his special ultimate Invoke. The three abilities he learns throughout leveling up can have three instances, which serve as the basic ingredients or components for him to create a new ability using his ultimate. Once the reagents or elements are combined, he can invoke one out of ten different abilities. All of his invoked abilities are capable of a multitude of actions, from damaging enemies to aiding his allies, and even saving himself from danger. His three reagents can be upgraded up to level 7 which determines the power and potency of his invoked abilities, making it more powerful than an ordinary spell. Because of this, he can be played in almost any role possible. Invoker can be a carry, semi-carry, ganker, pusher, initiator or even support. His three reagents provide passive attributes with each level, and each instance of his reagents provides a passive bonus, allowing for specialization at early levels and situational boosts at later levels. His extremely flexible nature allows him to use many different combinations of items effectively but also make him dependent on solid builds and a good gold advantage. Because of the extra points needed to level his three reagents, Invoker also has a special Attribute Bonus ability at level 25 that allows him to gain 6 points in all stats.', 'admin', '2016-01-18 22:54:26', 'null', 'null', 'Invoker.png'),
(20, 'Phantom Lancer', 'Carry', 'Azwraith the Phantom Lancer is a melee agility carry and pusher because of his capability of generating multiple illusions in a matter of seconds. He requires deep cunning, positioning, and most importantly, great micromanagement as his illusions might just get in the way rather than help the situation if not utilized correctly. Many of his abilities help him in his creation of images, allowing him to always have a companion. He has a nuke ability in Spirit Lance icon.png Spirit Lance, which deals high damage, slows the target, and creates an illusion at his target s location. His escape ability Doppelganger icon.png Doppelganger allows him to quickly relocate himself and any nearby illusions while creating additional ones, possibly tricking enemies into wasting their spells and time in trying to kill said illusions. His passive Phantom Rush icon.png Phantom Rush allows him and his illusions to close the distance toward a target when issued an attack order, giving him the ability to quickly focus single targets in battle. His ultimate Juxtapose. Juxtapose gives him the ability to generate a large number of illusions when attacking a target, while giving said illusions the ability to replicate themselves as well. Phantom Lancer is an extremely mobile hero who is hard to pin down and can quickly overwhelm his opponents in battle.', 'admin', '2016-01-18 22:55:17', 'null', 'null', 'Phantom_Lancer.png');

-- --------------------------------------------------------

--
-- Table structure for table `table_users`
--

CREATE TABLE IF NOT EXISTS `table_users` (
  `UserID` int(11) NOT NULL AUTO_INCREMENT,
  `Name` varchar(50) NOT NULL,
  `Address` varchar(50) NOT NULL,
  `Username` varchar(50) NOT NULL,
  `Password` varchar(50) NOT NULL,
  `Email` varchar(50) NOT NULL,
  `Usertype` varchar(50) NOT NULL,
  PRIMARY KEY (`UserID`)
) ENGINE=InnoDB  DEFAULT CHARSET=utf8 AUTO_INCREMENT=9 ;

--
-- Dumping data for table `table_users`
--

INSERT INTO `table_users` (`UserID`, `Name`, `Address`, `Username`, `Password`, `Email`, `Usertype`) VALUES
(1, 'Administrator', 'none', 'Admin', 'pratik', 'admin@gnp.com', 'user'),
(2, 'Member', 'member', 'member', 'member', 'member@gmail,com', 'member'),
(3, 'Ram Thapa', 'Dilli', 'Ram', 'ram123', 'Ram@gmail.com', 'member'),
(5, 'Bibek Hamal', 'Koteshwor', 'bibek', 'bibek12', 'bibek@gmail.com', 'member'),
(6, 'Amrit Karki', 'Koteshwor', 'Amrit', 'Amrit', 'amrit@yahoo.com', 'member'),
(8, 'Ayush Karki', 'Lokunthali', 'Ayush', 'ayush', 'ayush@gmail.com', 'member');

/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
/*!40101 SET CHARACTER_SET_RESULTS=@OLD_CHARACTER_SET_RESULTS */;
/*!40101 SET COLLATION_CONNECTION=@OLD_COLLATION_CONNECTION */;
