﻿using System;
using System.Collections.Generic;
using System.Text;

namespace BSGO_Server
{
    class PlayerProtocol : Protocol
    {
        public enum Request : ushort
        {
            MoveItem = 1,
            BuySkill = 2,
            SelectTitle = 3,
            BindSticker = 4,
            SelectConsumable = 5,
            UnbindSticker = 6,
            AddShip = 7,
            RemoveShip = 8,
            SelectShip = 9,
            UpgradeShip = 10,
            RepairSystem = 11,
            RepairShip = 12,
            ScrapShip = 13,
            CreateAvatar = 14,
            SelectFaction = 0xF,
            UpgradeSystem = 0x10,
            SetShipName = 17,
            UseAugment = 18,
            [Obsolete]
            OldChangeFaction = 19,
            ChooseDailyBonus = 20,
            UpgradeSystemByPack = 21,
            MoveAll = 22,
            ReadMail = 23,
            RemoveMail = 24,
            MailAction = 25,
            RepairAll = 26,
            [Obsolete]
            CheckUserBonus = 27,
            CheckNameAvailability = 28,
            PopupSeen = 30,
            ChooseName = 0x20,
            CreateAvatarFactionChange = 33,
            [Obsolete]
            OldChangeName = 34,
            InstantSkillBuy = 35,
            ReduceSkillLearnTime = 36,
            SubmitMission = 37,
            AugmentMassActivation = 38,
            SendDradisData = 39,
            RequestCharacterServices = 40,
            ChangeFaction = 41,
            ChangeName = 42,
            ChangeAvatar = 43,
            ResourceHardcap = 44,
            DeselectTitle = 45
        }

        public enum Reply : ushort
        {
            Reset = 1,
            PlayerInfo = 2,
            Skills = 3,
            Missions = 4,
            RemoveMissions = 5,
            Duties = 6,
            HoldItems = 7,
            RemoveHoldItems = 8,
            LockerItems = 9,
            RemoveLockerItems = 10,
            ShipInfo = 11,
            Slots = 12,
            Stickers = 13,
            RemoveStickers = 14,
            AddShip = 0xF,
            RemoveShip = 0x10,
            ActiveShip = 17,
            ShipName = 19,
            NameAvailable = 20,
            NameNotAvailable = 21,
            ID = 22,
            Name = 23,
            Faction = 24,
            Experience = 25,
            SpentExperience = 26,
            Level = 27,
            NormalExperience = 28,
            Avatar = 29,
            Loot = 30,
            RemoveLootItems = 0x1F,
            Stats = 0x20,
            [Obsolete]
            AbilityValidation = 33,
            PaymentInfo = 34,
            Counters = 35,
            Title = 36,
            ResetDuties = 37,
            AllowFactionSwitch = 38,
            Factors = 39,
            RemoveFactors = 40,
            Mail = 41,
            RemoveMail = 42,
            Capability = 43,
            AnswerUserBonus = 44,
            FactorModify = 45,
            UpdatePopupSeenList = 50,
            CannotStackBoosters = 51,
            Anchor = 52,
            Unanchor = 53,
            CarrierDradis = 54,
            HoldOverflow = 55,
            SettingsInfo = 56,
            [Obsolete]
            DotArea = 57,
            [Obsolete]
            SlotStats = 58,
            ActivateOnByDefaultSlots = 59,
            WaterExchangeValues = 60,
            BonusMapParts = 61,
            Statistics = 62,
            CharacterServices = 0x3F,
            FactionChangeSuccess = 0x40,
            NameChangeSuccess = 65,
            AvatarChangeSuccess = 66,
            CharacterServiceError = 67,
            ResourceHardcap = 68
        }

        public enum DamageOverTimeEffect : ushort
        {
            SectorBorder,
            MineField,
            SpeedDebuff,
            PowerDrain,
            DradisRange
        }

        public PlayerProtocol()
            : base(ProtocolID.Player)
        {
        }

        public static PlayerProtocol GetProtocol()
        {
            return ProtocolManager.GetProtocol(ProtocolID.Player) as PlayerProtocol;
        }

        public void SendPlayerID()
        {

        }

        public override void ParseMessage(int index, BgoProtocolReader br)
        {
            ushort msgType = (ushort)br.ReadUInt16();

            switch ((Request)msgType)
            {
                default:
                    Log.Add(LogSeverity.ERROR, string.Format("Unknown msgType \"{0}\" on {1}Protocol.", (Request)msgType, protocolID));
                    break;
            }
        }
    }
}
