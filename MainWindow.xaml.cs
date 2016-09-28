using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using Xceed.Wpf.Toolkit;

namespace ChartacterCreator
{
    
    public partial class MainWindow : Window
    {

        public static string charName;                          //Variables used in Window1.xaml.cs
        public static string charGender;
        public static string charAlignment1;
        public static string charAlignment2;
        public static string charAlignmentFull;
        public static string charRace;
        public static string charClass;
        public static string charArchetype;
        public static int charHeightFeet;
        public static int charHeightInches;
        public static int charWeight;
        public static int charHealthPoints;
        public static int charWealth;
        public static int charSTR;
        public static int charDEX;
        public static int charCON;
        public static int charINT;
        public static int charWIS;
        public static int charCHA;

        List<Race> raceList = new List<Race>();                 //List populated by character races
        List<Classes> classesList = new List<Classes>();        //List populates by character classes

        List<string> alchArch = new List<string>();
        List<string> barbArch = new List<string>();
        List<string> bardArch = new List<string>();
        List<string> cavaArch = new List<string>();
        List<string> clerArch = new List<string>();
        List<string> druiArch = new List<string>();
        List<string> fighArch = new List<string>();
        List<string> gunsArch = new List<string>();
        List<string> inquArch = new List<string>();
        List<string> maguArch = new List<string>();
        List<string> monkArch = new List<string>();
        List<string> oracArch = new List<string>();
        List<string> palaArch = new List<string>();
        List<string> rangArch = new List<string>();
        List<string> roguArch = new List<string>();
        List<string> sorcArch = new List<string>();
        List<string> summArch = new List<string>();
        List<string> witcArch = new List<string>();
        List<string> wizaArch = new List<string>();
        

        //Creating instances of the Races class.

        Race Dwarf = new Race("Dwarf", "Dwarves as a people are short in stature, and often in temper. Though tough and wise, they frequently speak their minds, mostly in a terse manor. This gives them a higher than average constitution and wisdom, but takes away from charisma.", 45, 43, 150, 120, 4, 2, 1, 4, 2, 1, 4, 2, 7, 4, 2, 7, 0, 0, 2, 0, 2, -2);
        Race Elf = new Race("Elf", "Long of life and limb, elves have a natural affinity for both nature and magic. Their lithe and nimble bodies make them extremely dexterous, yet leaves them generally more frail than other races.", 64, 64, 110, 90, 8, 2, 1, 6, 2, 1, 8, 2, 3, 6, 2, 3, 0, 2, -2, 2, 0, 0);
        Race Gnome = new Race("Gnome", "A diminutive people, gnomes have an insatiable curiosity that causes many to lead lives of artisans and craftsmen. This, combined with their small stature, has lead many to mistakenly believe them soft. Though weak, they are surprisingly tough and generally charismatic.", 36, 34, 35, 30, 4, 2, 1, 4, 2, 1, 4, 2, 1, 4, 2, 1, -2, 0, 2, 0, 0, 2);
        Race HalfElf = new Race("Half-Elf", "Often seen as the unwelcome by-product of a human-elven tryst, half-elves inherit traits from both of their parents, though often not a place in their societies. This varied nature allows half-elves to select one stat to gain a +2 bonus.", 62, 60, 100, 90, 8, 2, 1, 8, 2, 1, 8, 2, 5, 8, 2, 5, 0, 0, 0, 0, 0, 0);
        Race HalfOrc = new Race("Half-Orc", "Half-orcs are the result of rare relations between humans and orcs. They often spend their lives struggling against distrust from humans and disdain from orcs, and may choose one stat to receive a +2 bonus to represent which society they chose.", 58, 53, 150, 110, 12, 2, 1, 12, 2, 1, 12, 2, 7, 12, 2, 7, 0, 0, 0, 0, 0, 0);
        Race Halfling = new Race("Halfling", "Small and friendly, halflings are inquisitive by nature. Like gnomes, halflings suffer from lower-than-average strength, though unlike their short fellows, their curiosity often gets them into trouble; something they must rely on their nimbleness and charm to get them out of.", 32, 30, 30, 25, 4, 2, 1, 4, 2, 1, 4, 2, 1, 4, 2, 1, -2, 2, 0, 0, 0, 2);
        Race Human = new Race("Human", "Despite their short lifespans, confidence and heroism comes naturally to humans. Though they are unexceptional in many ways, there are few things a human cannot accomplish if he sets his mind to it. This allows humans to select one stat to give a +2 bonus.", 58, 53, 120, 85, 10, 2, 1, 10, 2, 1, 10, 2, 5, 10, 2, 5, 0, 0, 0, 0, 0, 0);

        //Creating instances of the Classes class.

        Classes Alchemist = new Classes("Alchemist", "Masters of potions and poisons, Alchemists have a knack for turing the most innocuous ingredients into the most potent concoctions. They often use these blends as toxins, simple explosives, and even self-transformative magic.", 8, 6, 3, 10);
        Classes Barbarian = new Classes("Barbarian", "Barbarians are the spirit of war and conflict. Their blood lust allows them to face enemies much stronger than themselves, and cull those who are weaker. Always at the front line, barbarians seek to test their strength against anyone in their path.", 12, 6, 3, 10);
        Classes Bard = new Classes("Bard", "Bards are supports adept in persuasion, manipulation, and inspiration. While they can take part in melee combat they excel at confusing their foes, and bolstering allies with magic, and performances.", 8, 6, 3, 10);
        Classes Cavalier = new Classes("Cavalier", "As comfortable in a royal court as they are on the battlefield, cavaliers have a talent for leading men as easily as they lead their steed. Though skilled at fighting from horseback, a cavalier's true power comes from his force of will.", 10, 6, 5, 10);
        Classes Cleric = new Classes("Cleric", "Clerics are the emissaries of the divine, who work the will of their deities through arms, and the magic of their gods.In combat they draw upon the power of their deities to increase their allies strength, hex their foes, or heal those in need.", 8, 6, 4, 10);
        Classes Druid = new Classes("Druid", "Druids are the devoted protectors of the wild, who call upon blessings from nature to combat their foes.As rewards for their servitutde druids are able to shape shift into beasts, summon companions, and call upon the elements at will. Note: Druids must be some form of neutral alignment.", 8, 6, 2, 10);
        Classes Fighter = new Classes("Fighter", "Fighters are combatants, plain and simple. Whatever weapons and armor they choose to wear, you can be sure of one thing - a fighter will feel most at home where others may fear to stand.", 10, 6, 5, 10);
        Classes Gunslinger = new Classes("Gunslinger", "Gunslingers are masters of a burgeoning new type of weapon - firearms. Able to see the future potential of the currently crude technology, Gunslingers take a battlefield position normally reserved for the magically inclined; lethality at a long range.", 10, 6, 5, 10);
        Classes Inquisitor = new Classes("Inquisitor", "Despite a calling that would make one naturally distrusting, inquisitors often travel with other - often times to mask their own presence from those they hunt. Answering only to their diety and their own sense of justice, inquisitors root out evil wherever it may hide.", 8, 6, 4, 10);
        Classes Magus = new Classes("Magus", "A magus is a master of both martial and magical arts. By blending the use of a single weapon, practiced to perfection, and powerful magic, studied to supremacy, magi are a force few enemies would dare to stand against.", 8, 6, 4, 10);
        Classes Monk = new Classes("Monk", "Monks devote themselves to the martial arts, and spend their lives strengthening their bodies, and mental fortitude. They seek out methods of battle beyond normal weaponry, and through strict discipline, are able to accomplish physical feats far superior to ordinary men.", 8, 6, 1, 10);
        Classes Oracle = new Classes("Oracle", "Divine vessels selected by the gods, oracles gain mysterious powers without choice. Given both gifts, and curses, the oracle's powers range from apocalyptic to life giving.", 8, 6, 3, 10);
        Classes Paladin = new Classes("Paladin", "Dedicating their lives against evil, paladins seek out to spread divine justice, and virtuous teachings.These holy champions serve as beacons for their allies within battle, risking their lives to proctect those in need.", 10, 6, 5, 10);
        Classes Ranger = new Classes("Ranger", "Rangers are specilists in the hunting and tracking arts. Whether they choose to use their skills to slay the many man-eating creatures found on the frontier, or fugitives amongst their own kind, one thing is certain - if a ranger is on the hunt, his prey will not elude him for long.", 10, 6, 5, 10);
        Classes Rogue = new Classes("Rogue", "Rogues live in the shadows, manipulating people and playing games few others even know exist. Masters of dozens of shadowy arts, from acrobatics to disguise, the best rogues are the ones you don't even know are there.", 8, 6, 4, 10);
        Classes Sorcerer = new Classes("Sorcerer", "Strengthened by the threat of their arcane powers consuming their souls, sorcerers endlessly refine their magical powers.They excel at casting a few favored spells, making them powerful battle mages, wielding powers few men could imagine.", 6, 6, 2, 10);
        Classes Summoner = new Classes("Summoner", "While the practice of pulling monsters from far-off planes is far from uncommon, none are so skilled at it as Summoners. By focusing their studies on a single outsider, known as an eidolon, a summoner can form a powerful bond with his chosen familiar.", 8, 6, 2, 10);
        Classes Witch = new Classes("Witch", "There are many avenues of study for the magically inclined, but none is as fast or simple as that of the witch. By creating a pact with an otherworldly power, witches gain access to a host of spells and hexes, though often without ever understand the nature of their power source.", 6, 6, 3, 10);
        Classes Wizard = new Classes("Wizard", "Wizards have a deeper understanding of the mystical arts than many other practitioners of magic due to the nature of their power. While others may be born with their magic, or later blessed, or even make a deal with otherworldly forces, a wizard studies to gain his power.", 6, 6, 2, 10);
        

        Random diceRoll = new Random();                             //Used in all random rolls during character creation

        public MainWindow()
        {
            InitializeComponent();
            textBox.IsReadOnly = true;
            textBox1.IsReadOnly = true;
            textBox3.IsReadOnly = true;
            raceList.Add(Dwarf);                                    //Populating raceList with all player races
            raceList.Add(Elf);                                      
            raceList.Add(Gnome);
            raceList.Add(HalfElf);
            raceList.Add(HalfOrc);
            raceList.Add(Halfling);
            raceList.Add(Human);

            classesList.Add(Alchemist);                             //Populating classesList with all player classes
            classesList.Add(Barbarian);
            classesList.Add(Bard);
            classesList.Add(Cavalier);
            classesList.Add(Cleric);
            classesList.Add(Druid);
            classesList.Add(Fighter);
            classesList.Add(Gunslinger);
            classesList.Add(Inquisitor);
            classesList.Add(Magus);
            classesList.Add(Monk);
            classesList.Add(Oracle);
            classesList.Add(Paladin);
            classesList.Add(Ranger);
            classesList.Add(Rogue);
            classesList.Add(Sorcerer);
            classesList.Add(Summoner);
            classesList.Add(Witch);
            classesList.Add(Wizard);

            alchArch.Add("Beastmorph");                                         //Populating the archetype list for each class
            alchArch.Add("Blazing Torchbearer");
            alchArch.Add("Chirurgeon");
            alchArch.Add("Clone Master");
            alchArch.Add("Crypt Breaker");
            alchArch.Add("Grenadier");
            alchArch.Add("Homunculist");
            alchArch.Add("Inspired Chemist");
            alchArch.Add("Internal Alchemist");
            alchArch.Add("Mindchemist");
            alchArch.Add("Preservationist");
            alchArch.Add("Psychonaut");
            alchArch.Add("Ragechemist");
            alchArch.Add("Reanimator");
            alchArch.Add("Trap Breaker");
            alchArch.Add("Visionary Researcher");
            alchArch.Add("Vivisectionist");

            barbArch.Add("Armored Hulk");
            barbArch.Add("Breaker");
            barbArch.Add("Brutal Pugilist");
            barbArch.Add("Burn Rider");
            barbArch.Add("Drunken Brute");
            barbArch.Add("Drunken Rager");
            barbArch.Add("Elemental Kin");
            barbArch.Add("Hurler");
            barbArch.Add("Invulnerable Rager");
            barbArch.Add("Jungle Rager");
            barbArch.Add("Liberator");
            barbArch.Add("Mad Dog");
            barbArch.Add("Mounted Fury");
            barbArch.Add("Pack Rager");
            barbArch.Add("Primal Hunter");
            barbArch.Add("Raging Cannibal");
            barbArch.Add("Savage Barbarian");
            barbArch.Add("Savage Technologist");
            barbArch.Add("Scarred Rager");
            barbArch.Add("Sea Reaver");
            barbArch.Add("Superstitious");
            barbArch.Add("True Primitive");
            barbArch.Add("Urban Barbarian");
            barbArch.Add("Wild Rager");

            bardArch.Add("Animal Speaker");
            bardArch.Add("Arcane Duelist");
            bardArch.Add("Archeologist");
            bardArch.Add("Arbiter");
            bardArch.Add("Arcane Healer");
            bardArch.Add("Archivist");
            bardArch.Add("Buccaneer");
            bardArch.Add("Celebrity");
            bardArch.Add("Court Bard");
            bardArch.Add("Daredevil");
            bardArch.Add("Demagogue");
            bardArch.Add("Dervish Dancer");
            bardArch.Add("Dervish of Dawn");
            bardArch.Add("Detective");
            bardArch.Add("Dirge Bard");
            bardArch.Add("Diva");
            bardArch.Add("Duettist");
            bardArch.Add("Flame Dancer");
            bardArch.Add("Geisha");
            bardArch.Add("Juggler");
            bardArch.Add("Lotus Geisha");
            bardArch.Add("Magician");
            bardArch.Add("Negotiator");
            bardArch.Add("Sandman");
            bardArch.Add("Savage Skald");
            bardArch.Add("Sea Singer");
            bardArch.Add("Songhealer");
            bardArch.Add("Sound Striker");
            bardArch.Add("Street Performer");
            bardArch.Add("Thundercaller");
            bardArch.Add("Voice of the Wild");

            cavaArch.Add("Beast Rider");
            cavaArch.Add("Castellan");
            cavaArch.Add("Daring Champion");
            cavaArch.Add("Dune Drifter");
            cavaArch.Add("Emissary");
            cavaArch.Add("Gendarme");
            cavaArch.Add("Herald Squire");
            cavaArch.Add("Honor Guard");
            cavaArch.Add("Horselord");
            cavaArch.Add("Huntmaster");
            cavaArch.Add("Luring Cavalier");
            cavaArch.Add("Musketeer");
            cavaArch.Add("Standard Bearer");
            cavaArch.Add("Strategist");
            cavaArch.Add("Wave Rider");

            clerArch.Add("Cloistered Cleric");
            clerArch.Add("Crusader");
            clerArch.Add("Devilbane Priest");
            clerArch.Add("Devout Pilgrim");
            clerArch.Add("Divine Strategist");
            clerArch.Add("Ecclesitheurge");
            clerArch.Add("Evangelist");
            clerArch.Add("Hidden Priest");
            clerArch.Add("Iron Priest");
            clerArch.Add("Merciful Healer");
            clerArch.Add("Roaming Exorcist");
            clerArch.Add("Scroll Scholar");
            clerArch.Add("Separatist");
            clerArch.Add("Theologian");
            clerArch.Add("Undead Lord");

            druiArch.Add("Ancient Guardian");
            druiArch.Add("Elemental Ally");
            druiArch.Add("Feral Shifter");
            druiArch.Add("Goliath Druid");
            druiArch.Add("Green Faith Initiate");
            druiArch.Add("Leshy Warden");
            druiArch.Add("Menhir Savant");
            druiArch.Add("MoonCaller");
            druiArch.Add("Nature Fang");
            druiArch.Add("Pack Lord");
            druiArch.Add("Reincarnated Druid");
            druiArch.Add("Storm Druid");
            druiArch.Add("Survivor Druid");
            druiArch.Add("Wild Whisperer");
            druiArch.Add("World Walker");

            fighArch.Add("Archer");
            fighArch.Add("Armor Master");
            fighArch.Add("Blackjack");
            fighArch.Add("Brawler");
            fighArch.Add("Buckler Duelist");
            fighArch.Add("Cad");
            fighArch.Add("Corsair");
            fighArch.Add("Crossbowman");
            fighArch.Add("Cyber-Soldier");
            fighArch.Add("Dervish of Dawn");
            fighArch.Add("Dragoon");
            fighArch.Add("Drill Sergeant");
            fighArch.Add("Eldritch Guardian");
            fighArch.Add("Free Hand Fighter");
            fighArch.Add("Free-Style Fighter");
            fighArch.Add("Gladiator");
            fighArch.Add("Learned Duelist");
            fighArch.Add("Lore Warden");
            fighArch.Add("Martial Master");
            fighArch.Add("Mobile Fighter");
            fighArch.Add("Mutation Warrior");
            fighArch.Add("Pack Mule");
            fighArch.Add("Phalanx Soldier");
            fighArch.Add("Polearm Master");
            fighArch.Add("Relic Master");
            fighArch.Add("Roughrider");
            fighArch.Add("Savage Warrior");
            fighArch.Add("Sensate");
            fighArch.Add("Shielded Fighter");
            fighArch.Add("Siegebreaker");
            fighArch.Add("Swordlord");
            fighArch.Add("Tactician");
            fighArch.Add("Thunderstriker");
            fighArch.Add("Titan Fighter");
            fighArch.Add("Tower Shield Specialist");
            fighArch.Add("Trench Fighter");
            fighArch.Add("Two-Handed Fighter");
            fighArch.Add("Two-Weapon Warrior");
            fighArch.Add("Unarmed Fighter");
            fighArch.Add("Unbreakable");
            fighArch.Add("Vengeful Hunter");
            fighArch.Add("Viking");
            fighArch.Add("Weapon Bearer Squire");
            fighArch.Add("Weapon Master");

            gunsArch.Add("Bolt Ace");
            gunsArch.Add("Gun Scavenger");
            gunsArch.Add("Gun Tank");
            gunsArch.Add("Gunner Squire");
            gunsArch.Add("Mucket Master");
            gunsArch.Add("Mysertious Stranger");
            gunsArch.Add("Pistolero");
            gunsArch.Add("Siege Gunner");
            gunsArch.Add("Techslinger");
            gunsArch.Add("Wyrm Sniper");

            inquArch.Add("Cold Iron Warden");
            inquArch.Add("Exorcist");
            inquArch.Add("Heretic");
            inquArch.Add("Iconoclast");
            inquArch.Add("Infiltrator");
            inquArch.Add("Preacher");
            inquArch.Add("Sacred Huntmaster");
            inquArch.Add("Sanctified Slayer");
            inquArch.Add("Sin Eater");
            inquArch.Add("Spellbreaker");
            inquArch.Add("Suit Seeker");
            inquArch.Add("Vampire Hunter");
            inquArch.Add("Witch Hunter");

            maguArch.Add("Beastblade");
            maguArch.Add("Bladebound");
            maguArch.Add("Bladed Scarf Dancer");
            maguArch.Add("Card Caster");
            maguArch.Add("Eldritch Archer");
            maguArch.Add("Eldritch Scion");
            maguArch.Add("Esoteric");
            maguArch.Add("Greensting Slayer");
            maguArch.Add("Hexcrafter");
            maguArch.Add("Kensai");
            maguArch.Add("Mindblade");
            maguArch.Add("Myrmidarch");
            maguArch.Add("Skirnir");
            maguArch.Add("Soul forger");
            maguArch.Add("Spellblade");
            maguArch.Add("Spire Defender");
            maguArch.Add("Staff Magus");

            monkArch.Add("Drunken Master");
            monkArch.Add("Far Strike Monk");
            monkArch.Add("Flowing Monk");
            monkArch.Add("Hamatulatsu Master");
            monkArch.Add("Harrow Warden");
            monkArch.Add("Hungry Ghost Monk");
            monkArch.Add("Kata Master");
            monkArch.Add("Ki Mystic");
            monkArch.Add("Maneuver Master");
            monkArch.Add("Martial Artist");
            monkArch.Add("Master of Many Styles");
            monkArch.Add("Monk of the Empty Hand");
            monkArch.Add("Monk of the Four Winds");
            monkArch.Add("Monk of the Healing Hand");
            monkArch.Add("Monk of the Iron Mountain");
            monkArch.Add("Monk of the Lotus");
            monkArch.Add("Monk of the Sacred Mountain");
            monkArch.Add("Monk of the Seven Winds");
            monkArch.Add("Qinggong Monk");
            monkArch.Add("Sensei");
            monkArch.Add("Sohei");
            monkArch.Add("Spirit Master");
            monkArch.Add("Terra-Cotta Monk");
            monkArch.Add("Tetori");
            monkArch.Add("Weapon Adept");
            monkArch.Add("Wildcat");
            monkArch.Add("Zen Archer");

            oracArch.Add("Black-Blooded Oracle");
            oracArch.Add("Dual-Cursed Oracle");
            oracArch.Add("Elementalist Oracle");
            oracArch.Add("Enlightened Philosopher");
            oracArch.Add("Planar Oracle");
            oracArch.Add("Possessed Oracle");
            oracArch.Add("Psychic Searcher");
            oracArch.Add("Seeker");
            oracArch.Add("Seer");
            oracArch.Add("Spirit Guide");
            oracArch.Add("Stargazer");
            oracArch.Add("Warsighted");

            palaArch.Add("Chosen One");
            palaArch.Add("Combat Healer Squire");
            palaArch.Add("Divine Defender");
            palaArch.Add("Divine Hunter");
            palaArch.Add("Empyreal Knight");
            palaArch.Add("Enlightened Paladin");
            palaArch.Add("Holy Guide");
            palaArch.Add("Holy Gun");
            palaArch.Add("Holy Tactician");
            palaArch.Add("Hospitaler");

            rangArch.Add("Battle Scout");
            rangArch.Add("Beastmaster");
            rangArch.Add("Cinderwalker");
            rangArch.Add("Corpse Hunter");
            rangArch.Add("Deep Walker");
            rangArch.Add("Demonslayer");
            rangArch.Add("Divine Marksman");
            rangArch.Add("Divine Tracker");
            rangArch.Add("Dragon Hunter");
            rangArch.Add("Dungeon Rover");
            rangArch.Add("Falconer");
            rangArch.Add("FreeBooter");
            rangArch.Add("Galvanic Saboteur");
            rangArch.Add("Groom");
            rangArch.Add("Guide");
            rangArch.Add("Hooded Champion");
            rangArch.Add("Horse Lord");
            rangArch.Add("Infiltrator");
            rangArch.Add("Shapeshifter");
            rangArch.Add("Skirmisher");
            rangArch.Add("Sky Stalker");
            rangArch.Add("Spirit Ranger");
            rangArch.Add("Toxophilite");
            rangArch.Add("Trapper");
            rangArch.Add("Trophy Hunter");
            rangArch.Add("Urban Ranger");
            rangArch.Add("Warden");
            rangArch.Add("Wild Hunter");
            rangArch.Add("Wild Stalker");
            rangArch.Add("Witchguard");
            rangArch.Add("Woodland Skirmisher");
            rangArch.Add("Yokai Hunter");

            roguArch.Add("Acrobat");
            roguArch.Add("Bandit");
            roguArch.Add("Burglar");
            roguArch.Add("Carnivalist");
            roguArch.Add("Chameleon");
            roguArch.Add("Charlatan");
            roguArch.Add("Counterfeit Mage");
            roguArch.Add("Cutpurse");
            roguArch.Add("Driver");
            roguArch.Add("Investigator");
            roguArch.Add("Knife Master");
            roguArch.Add("Liberator");
            roguArch.Add("Makeshift Scrapper");
            roguArch.Add("Pirate");
            roguArch.Add("Poisoner");
            roguArch.Add("Rake");
            roguArch.Add("River Rat");
            roguArch.Add("Roof Runner");
            roguArch.Add("Sanctified Rogue");
            roguArch.Add("Sapper");
            roguArch.Add("Scavenger");
            roguArch.Add("Scout");
            roguArch.Add("Scroll Scoundrel");
            roguArch.Add("Smuggler");
            roguArch.Add("Sniper");
            roguArch.Add("Spy");
            roguArch.Add("Survivalist");
            roguArch.Add("Swashbuckler");
            roguArch.Add("Swindler");
            roguArch.Add("Thug");
            roguArch.Add("Trapsmith");
            roguArch.Add("Underground Chemist");
            roguArch.Add("Vexing Dodger");

            sorcArch.Add("Crossblooded");
            sorcArch.Add("Dragon Drinker");
            sorcArch.Add("Eldritch Scrapper");
            sorcArch.Add("False Priest");
            sorcArch.Add("Mongrel Mage");
            sorcArch.Add("Seeker");
            sorcArch.Add("Sorcerer of Sleep");
            sorcArch.Add("Tattooed Sorcerer");
            sorcArch.Add("Wildblooded - Anarchic");
            sorcArch.Add("Wildblooded - Arial");
            sorcArch.Add("Wildblooded - Bedrock");
            sorcArch.Add("Wildblooded - Brutal");
            sorcArch.Add("Wildblooded - Dark Fey");
            sorcArch.Add("Wildblooded - Empyreal");
            sorcArch.Add("Wildblooded - Envenomed");
            sorcArch.Add("Wildblooded - Groveborn");
            sorcArch.Add("Wildblooded - Karmic");
            sorcArch.Add("Wildblooded - Lifewater");
            sorcArch.Add("Wildblooded - Linnorm");
            sorcArch.Add("Wildblooded - Pit-Touched");
            sorcArch.Add("Wildblooded - Primal");
            sorcArch.Add("Wildblooded - Retribution");
            sorcArch.Add("Wildblooded - Rime-Blooded");
            sorcArch.Add("Wildblooded - Sage");
            sorcArch.Add("Wildblooded - Sanguine");
            sorcArch.Add("Wildblooded - Seaborn");
            sorcArch.Add("Wildblooded - Shahzada");
            sorcArch.Add("Wildblooded - Sylvan");
            sorcArch.Add("Wildblooded - Umbral");
            sorcArch.Add("Wildblooded - Visionary");
            sorcArch.Add("Wildblooded - Void-Touched");
            sorcArch.Add("Wildblooded - Warped");

            summArch.Add("Blood Summoner");
            summArch.Add("Broodmaster");
            summArch.Add("Counter-Summoner");
            summArch.Add("Evolutionist");
            summArch.Add("First Worlder");
            summArch.Add("Master Summoner");
            summArch.Add("Morphic Savant");
            summArch.Add("Naturalist");
            summArch.Add("Spirit Summoner");
            summArch.Add("Story Summoner");
            summArch.Add("Synthesist");
            summArch.Add("Unwavering Conduit");
            summArch.Add("Wind Caller");

            witcArch.Add("Alley Witch");
            witcArch.Add("Beast-bonded");
            witcArch.Add("Bouda");
            witcArch.Add("Cartomancer");
            witcArch.Add("Dark Sister");
            witcArch.Add("Dimensional Occultist");
            witcArch.Add("Gravewalker");
            witcArch.Add("Hedge Witch");
            witcArch.Add("Herb Witch");
            witcArch.Add("Hex Channeler");
            witcArch.Add("Ley Line Guardian");
            witcArch.Add("Medium");
            witcArch.Add("Mountain Witch");
            witcArch.Add("Sea Witch");
            witcArch.Add("Synergist");
            witcArch.Add("Veneficus Witch");
            witcArch.Add("White-Haired Witch");
            witcArch.Add("Winder Witch");

            wizaArch.Add("Arcane Bomber");
            wizaArch.Add("Exploiter Wizard");
            wizaArch.Add("Familiar Adept");
            wizaArch.Add("Pact Wizard");
            wizaArch.Add("Primalist");
            wizaArch.Add("Scrollmaster");
            wizaArch.Add("Scroll Scholar");
            wizaArch.Add("Shadowcaster");
            wizaArch.Add("Siege Mage");
            wizaArch.Add("Spellslinger");
            wizaArch.Add("Spell Sage");
            wizaArch.Add("Spirit Binder");
            wizaArch.Add("Spirit Whisperer");

            

            for (int i = 0; i < raceList.Count; i++)                                    //Populating race combobox with all races
            {
                raceBox.Items.Add(raceList[i].raceName);
            }

            for (int i = 0; i < classesList.Count; i++)                                 //Populating class combobox with all classes
            {
                classBox.Items.Add(classesList[i].className);
            }

            
        }

        private void raceBox_DropDownClosed(object sender, EventArgs e)                 //Populate TextBox with information about selected Race
        {
            if (raceBox.SelectedIndex != -1)
            {
                textBox.Text = raceList[raceBox.SelectedIndex].raceDes;
                
            }
        }

        private void classBox_DropDownClosed(object sender, EventArgs e)                
        {
            if (classBox.SelectedIndex != -1)
            {
                archBox.IsEnabled = true;                                               //Enables the archetype combobox
                archBox.SelectedItem = null;
                
                radioButton2.IsEnabled = true;                                          //Defaults all alignment radio buttons to true. May change based on selected class.
                radioButton3.IsEnabled = true;
                radioButton4.IsEnabled = true;
                radioButton5.IsEnabled = true;
                radioButton6.IsEnabled = true;
                radioButton7.IsEnabled = true;
                
                
                textBox1.Text = classesList[classBox.SelectedIndex].classDes;           //Populate TextBox with information about selected Race


                switch (classBox.SelectedIndex)                                         //Populates archBox with archetypes of the selected class, and disables radio buttons as necessary.
                {
                    case 0:
                        archBox.Items.Clear();
                        for (int i = 0; i < alchArch.Count; i++)
                        {
                            archBox.Items.Add(alchArch[i]);
                        }
                        break;
                    case 1:
                        radioButton2.IsEnabled = false;

                        if (radioButton2.IsChecked == true)
                        {
                            radioButton2.IsChecked = false;
                        }
                        archBox.Items.Clear();
                        for (int i = 0; i < barbArch.Count; i++)
                        {
                            archBox.Items.Add(barbArch[i]);
                        }
                        break;
                    case 2:
                        archBox.Items.Clear();
                        for (int i = 0; i < bardArch.Count; i++)
                        {
                            archBox.Items.Add(bardArch[i]);
                        }
                        break;
                    case 3:
                        archBox.Items.Clear();
                        for (int i = 0; i < cavaArch.Count; i++)
                        {
                            archBox.Items.Add(cavaArch[i]);
                        }
                        break;
                    case 4:
                        archBox.Items.Clear();
                        for (int i = 0; i < clerArch.Count; i++)
                        {
                            archBox.Items.Add(clerArch[i]);
                        }
                        break;
                    case 5:
                        if(radioButton3.IsChecked == false && radioButton6.IsChecked == false)
                        {
                            radioButton2.IsChecked = false;
                            radioButton3.IsChecked = true;
                            radioButton4.IsChecked = false;
                            radioButton5.IsChecked = false;
                            radioButton6.IsChecked = true;
                            radioButton7.IsChecked = false;
                        }
                        archBox.Items.Clear();
                        for (int i = 0; i < druiArch.Count; i++)
                        {
                            archBox.Items.Add(druiArch[i]);
                        }
                        
                        break;
                    case 6:
                        archBox.Items.Clear();
                        for (int i = 0; i < fighArch.Count; i++)
                        {
                            archBox.Items.Add(fighArch[i]);
                        }
                        break;
                    case 7:
                        archBox.Items.Clear();
                        for (int i = 0; i < gunsArch.Count; i++)
                        {
                            archBox.Items.Add(gunsArch[i]);
                        }
                        break;
                    case 8:
                        archBox.Items.Clear();
                        for (int i = 0; i < inquArch.Count; i++)
                        {
                            archBox.Items.Add(inquArch[i]);
                        }
                        break;
                    case 9:
                        archBox.Items.Clear();
                        for (int i = 0; i < maguArch.Count; i++)
                        {
                            archBox.Items.Add(maguArch[i]);
                        }
                        break;
                    case 10:
                        radioButton2.IsChecked = true;
                        radioButton2.IsEnabled = false;
                        radioButton3.IsEnabled = false;
                        radioButton4.IsEnabled = false;
                        archBox.Items.Clear();
                        for (int i = 0; i < monkArch.Count; i++)
                        {
                            archBox.Items.Add(monkArch[i]);
                        }
                        break;
                    case 11:
                        archBox.Items.Clear();
                        for (int i = 0; i < oracArch.Count; i++)
                        {
                            archBox.Items.Add(oracArch[i]);
                        }
                        break;
                    case 12:
                        radioButton2.IsChecked = true;
                        radioButton5.IsChecked = true;
                        radioButton2.IsEnabled = false;
                        radioButton3.IsEnabled = false;
                        radioButton4.IsEnabled = false;
                        radioButton5.IsEnabled = false;
                        radioButton6.IsEnabled = false;
                        radioButton7.IsEnabled = false;
                        archBox.Items.Clear();
                        for (int i = 0; i < palaArch.Count; i++)
                        {
                            archBox.Items.Add(palaArch[i]);
                        }
                        break;
                    case 13:
                        archBox.Items.Clear();
                        for (int i = 0; i < rangArch.Count; i++)
                        {
                            archBox.Items.Add(rangArch[i]);
                        }
                        break;
                    case 14:
                        archBox.Items.Clear();
                        for (int i = 0; i < roguArch.Count; i++)
                        {
                            archBox.Items.Add(roguArch[i]);
                        }
                        break;
                    case 15:
                        archBox.Items.Clear();
                        for (int i = 0; i < sorcArch.Count; i++)
                        {
                            archBox.Items.Add(sorcArch[i]);
                        }
                        break;
                    case 16:
                        archBox.Items.Clear();
                        for (int i = 0; i < summArch.Count; i++)
                        {
                            archBox.Items.Add(summArch[i]);
                        }
                        break;
                    case 17:
                        archBox.Items.Clear();
                        for (int i = 0; i < witcArch.Count; i++)
                        {
                            archBox.Items.Add(witcArch[i]);
                        }
                        break;
                    case 18:
                        archBox.Items.Clear();
                        for (int i = 0; i < wizaArch.Count; i++)
                        {
                            archBox.Items.Add(wizaArch[i]);
                        }
                        break;

                }

            }
        }

        private void button_Click(object sender, RoutedEventArgs e)                         //Sets variables needed in Window1
        {

            charName = textBox2.Text;

            if(radioButton.IsChecked == true)
            {
                charGender = "Male";
            }else if(radioButton1.IsChecked == true)
            {
                charGender = "Female";
            }

            if (radioButton2.IsChecked == true)
            {
                charAlignment1 = "Lawful";
            }
            else if (radioButton3.IsChecked == true)
            {
                charAlignment1 = "Neutral";
            }
            else if (radioButton4.IsChecked == true)
            {
                charAlignment1 = "Chaotic";
            }

            if (radioButton5.IsChecked == true)
            {
                charAlignment2 = "Good";
            }
            else if (radioButton6.IsChecked == true)
            {
                charAlignment2 = "Neutral";
            }
            else if (radioButton7.IsChecked == true)
            {
                charAlignment2 = "Evil";
            }

            if(radioButton3.IsChecked == true && radioButton6.IsChecked == true)
            {
                charAlignmentFull = "True Neutral";
            }
            else { charAlignmentFull = charAlignment1 + " " + charAlignment2; }

            charRace = raceBox.SelectedValue.ToString();
            charClass = classBox.SelectedValue.ToString();
            charArchetype = archBox.SelectedValue.ToString();
            charHealthPoints = classesList[classBox.SelectedIndex].hitDie;


            charSTR = raceList[raceBox.SelectedIndex].strMod;
            charDEX = raceList[raceBox.SelectedIndex].dexMod;
            charCON = raceList[raceBox.SelectedIndex].conMod;
            charINT = raceList[raceBox.SelectedIndex].intMod;
            charWIS = raceList[raceBox.SelectedIndex].wisMod;
            charCHA = raceList[raceBox.SelectedIndex].chaMod;

            if (radioButton.IsChecked == true)                                      //Randomizes height and weight based on Race AS MALE
            {
                int heightAdd = 0;
                int weightAdd = 0;

                for(int i = 0; i < raceList[raceBox.SelectedIndex].heightMaleDiceNum; i++)
                {
                    heightAdd += (diceRoll.Next(1, raceList[raceBox.SelectedIndex].heightMaleDice + 1));
                }

                charHeightFeet = (raceList[raceBox.SelectedIndex].baseHeightMale + (heightAdd * raceList[raceBox.SelectedIndex].heightMaleMul)) / 12;
                charHeightInches = (raceList[raceBox.SelectedIndex].baseHeightMale + (heightAdd * raceList[raceBox.SelectedIndex].heightMaleMul)) % 12;


                for (int i = 0; i < raceList[raceBox.SelectedIndex].weightMaleDiceNum; i++)
                {
                    weightAdd += (diceRoll.Next(1, raceList[raceBox.SelectedIndex].weightMaleDice + 1));
                }

                charWeight = raceList[raceBox.SelectedIndex].baseWeightMale + (weightAdd * raceList[raceBox.SelectedIndex].weightMaleMul);


            }
            else if(radioButton1.IsChecked == true)                                 //Randomizes height and weight based on Race AS FEMALE
            {
                int heightAdd = 0;
                int weightAdd = 0;

                for (int i = 0; i < raceList[raceBox.SelectedIndex].heightFemaleDiceNum; i++)
                {
                    heightAdd += (diceRoll.Next(1, raceList[raceBox.SelectedIndex].heightFemaleDice + 1));
                }

                charHeightFeet = (raceList[raceBox.SelectedIndex].baseHeightFemale + (heightAdd * raceList[raceBox.SelectedIndex].heightFemaleMul)) / 12;
                charHeightInches = (raceList[raceBox.SelectedIndex].baseHeightFemale + (heightAdd * raceList[raceBox.SelectedIndex].heightFemaleMul)) % 12;


                for (int i = 0; i < raceList[raceBox.SelectedIndex].weightFemaleDiceNum; i++)
                {
                    weightAdd += (diceRoll.Next(1, raceList[raceBox.SelectedIndex].weightFemaleDice + 1));
                }

                charWeight = raceList[raceBox.SelectedIndex].baseWeightFemale + (weightAdd * raceList[raceBox.SelectedIndex].weightFemaleMul);

            }

            int wealthAdd = 0;

            for (int i = 0; i < classesList[classBox.SelectedIndex].wealthDiceNum; i++)
            {
                wealthAdd += (diceRoll.Next(1, classesList[classBox.SelectedIndex].wealthDice + 1));
            }

            charWealth = wealthAdd * classesList[classBox.SelectedIndex].wealthMul;
            

            Window1 charWindow = new Window1();
            charWindow.Show();
            
        }

        

        private void radioButton2_Click(object sender, RoutedEventArgs e)               //radioButton Click functions for managing alignment of Druid class
        {
            if(classBox.SelectedIndex == 5)
            {
                if (radioButton6.IsChecked != true)
                {
                    classBox.SelectedIndex = -1;
                    archBox.Items.Clear();
                    archBox.IsEnabled = false;
                    textBox1.Text = "";
                }
            }
            
        }

        private void radioButton4_Click(object sender, RoutedEventArgs e)
        {
            if (classBox.SelectedIndex == 5)
            {
                if (radioButton6.IsChecked != true)
                {
                    classBox.SelectedIndex = -1;
                    archBox.Items.Clear();
                    archBox.IsEnabled = false;
                    textBox1.Text = "";
                }
            }
        }

        private void radioButton5_Click(object sender, RoutedEventArgs e)
        {
            if (classBox.SelectedIndex == 5)
            {
                if (radioButton3.IsChecked != true)
                {
                    classBox.SelectedIndex = -1;
                    archBox.Items.Clear();
                    archBox.IsEnabled = false;
                    textBox1.Text = "";
                }
            }
        }

        private void radioButton7_Click(object sender, RoutedEventArgs e)
        {
            if (classBox.SelectedIndex == 5)
            {
                if (radioButton3.IsChecked != true)
                {
                    classBox.SelectedIndex = -1;
                    archBox.Items.Clear();
                    archBox.IsEnabled = false;
                    textBox1.Text = "";
                }
            }
        }

        private void checkBox_Checked(object sender, RoutedEventArgs e)                 //Checks that all necessary information is present before allowing checkbox to be checked. Disables all fields.
        {
            
            if (textBox2.Text != "" && (radioButton.IsChecked == true || radioButton1.IsChecked == true) && (radioButton2.IsChecked == true || radioButton3.IsChecked == true || radioButton4.IsChecked == true) && (radioButton5.IsChecked == true || radioButton6.IsChecked == true || radioButton7.IsChecked == true) && raceBox.SelectedIndex > -1 && classBox.SelectedIndex > -1 && archBox.SelectedIndex > -1)
            {
                textBox2.IsEnabled = false;
                radioButton.IsEnabled = false;
                radioButton1.IsEnabled = false;
                radioButton2.IsEnabled = false;
                radioButton3.IsEnabled = false;
                radioButton4.IsEnabled = false;
                radioButton5.IsEnabled = false;
                radioButton6.IsEnabled = false;
                radioButton7.IsEnabled = false;
                raceBox.IsEnabled = false;
                classBox.IsEnabled = false;
                archBox.IsEnabled = false;

                checkBox.IsChecked = true;

                button.IsEnabled = true;
            }
            else
            {
                checkBox.IsChecked = false;
            }
            
        }

        private void checkBox_Unchecked(object sender, RoutedEventArgs e)               //Enables fields that are available to selected class (Radio buttons disabled for Paladin since they can only be Lawful Good)
        {
            if (classBox.SelectedIndex != -1)
            {
                if (raceBox.SelectedIndex == 3 || raceBox.SelectedIndex == 4 || raceBox.SelectedIndex == 6)
                {
                    if (classBox.SelectedIndex == 1)
                    {
                        textBox2.IsEnabled = true;
                        radioButton.IsEnabled = true;
                        radioButton1.IsEnabled = true;
                        radioButton2.IsEnabled = false;
                        radioButton3.IsEnabled = true;
                        radioButton4.IsEnabled = true;
                        radioButton5.IsEnabled = true;
                        radioButton6.IsEnabled = true;
                        radioButton7.IsEnabled = true;
                        raceBox.IsEnabled = true;
                        classBox.IsEnabled = true;
                        archBox.IsEnabled = true;
                        button.IsEnabled = false;
                    }
                    else if (classBox.SelectedIndex == 10)
                    {
                        textBox2.IsEnabled = true;
                        radioButton.IsEnabled = true;
                        radioButton1.IsEnabled = true;
                        radioButton2.IsEnabled = false;
                        radioButton3.IsEnabled = false;
                        radioButton4.IsEnabled = false;
                        radioButton5.IsEnabled = true;
                        radioButton6.IsEnabled = true;
                        radioButton7.IsEnabled = true;
                        raceBox.IsEnabled = true;
                        classBox.IsEnabled = true;
                        archBox.IsEnabled = true;
                        button.IsEnabled = false;
                    }
                    else if (classBox.SelectedIndex == 12)
                    {
                        textBox2.IsEnabled = true;
                        radioButton.IsEnabled = true;
                        radioButton1.IsEnabled = false;
                        radioButton2.IsEnabled = false;
                        radioButton3.IsEnabled = false;
                        radioButton4.IsEnabled = false;
                        radioButton5.IsEnabled = false;
                        radioButton6.IsEnabled = false;
                        radioButton7.IsEnabled = false;
                        raceBox.IsEnabled = true;
                        classBox.IsEnabled = true;
                        archBox.IsEnabled = true;
                        button.IsEnabled = false;
                    }
                    else
                    {
                        textBox2.IsEnabled = true;
                        radioButton.IsEnabled = true;
                        radioButton1.IsEnabled = true;
                        radioButton2.IsEnabled = true;
                        radioButton3.IsEnabled = true;
                        radioButton4.IsEnabled = true;
                        radioButton5.IsEnabled = true;
                        radioButton6.IsEnabled = true;
                        radioButton7.IsEnabled = true;
                        raceBox.IsEnabled = true;
                        classBox.IsEnabled = true;
                        archBox.IsEnabled = true;
                        button.IsEnabled = false;
                    }
                }
                else
                {
                    if (classBox.SelectedIndex == 1)
                    {
                        textBox2.IsEnabled = true;
                        radioButton.IsEnabled = true;
                        radioButton1.IsEnabled = true;
                        radioButton2.IsEnabled = false;
                        radioButton3.IsEnabled = true;
                        radioButton4.IsEnabled = true;
                        radioButton5.IsEnabled = true;
                        radioButton6.IsEnabled = true;
                        radioButton7.IsEnabled = true;
                        raceBox.IsEnabled = true;
                        classBox.IsEnabled = true;
                        archBox.IsEnabled = true;
                        button.IsEnabled = false;
                    }
                    else if (classBox.SelectedIndex == 10)
                    {
                        textBox2.IsEnabled = true;
                        radioButton.IsEnabled = true;
                        radioButton1.IsEnabled = true;
                        radioButton2.IsEnabled = false;
                        radioButton3.IsEnabled = false;
                        radioButton4.IsEnabled = false;
                        radioButton5.IsEnabled = true;
                        radioButton6.IsEnabled = true;
                        radioButton7.IsEnabled = true;
                        raceBox.IsEnabled = true;
                        classBox.IsEnabled = true;
                        archBox.IsEnabled = true;
                        button.IsEnabled = false;
                    }
                    else if (classBox.SelectedIndex == 12)
                    {
                        textBox2.IsEnabled = true;
                        radioButton.IsEnabled = true;
                        radioButton1.IsEnabled = false;
                        radioButton2.IsEnabled = false;
                        radioButton3.IsEnabled = false;
                        radioButton4.IsEnabled = false;
                        radioButton5.IsEnabled = false;
                        radioButton6.IsEnabled = false;
                        radioButton7.IsEnabled = false;
                        raceBox.IsEnabled = true;
                        classBox.IsEnabled = true;
                        archBox.IsEnabled = true;
                        button.IsEnabled = false;
                    }
                    else
                    {
                        textBox2.IsEnabled = true;
                        radioButton.IsEnabled = true;
                        radioButton1.IsEnabled = true;
                        radioButton2.IsEnabled = true;
                        radioButton3.IsEnabled = true;
                        radioButton4.IsEnabled = true;
                        radioButton5.IsEnabled = true;
                        radioButton6.IsEnabled = true;
                        radioButton7.IsEnabled = true;
                        raceBox.IsEnabled = true;
                        classBox.IsEnabled = true;
                        archBox.IsEnabled = true;
                        button.IsEnabled = false;
                    }
                }
            }
        }
    }
}
