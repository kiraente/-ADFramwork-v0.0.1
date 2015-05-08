using UnityEngine;
using System.Collections;

namespace ADFramework.IItemCollections
{
    public interface IItemUsable
    {
        void ItemUse();     
    }
    public interface IItemDamageable
    {
        void ItemDamage();
    }
    public interface IItemDestroyable
    {
        void Destroy();
    }
    public interface IItemRepairable
    {
        void ItemRepair();
    }
    public interface IItemEquipable
    {
        void ItemEquip();
    }
    public interface IItemCraftable
    {
        void ItemCraft();
    }
    public interface IItemEnchantable
    {
        void ItemEnchant();
    }
    public interface IItemBreakable
    {
        void ItemBreak();
    }
    public interface IItemSellable
    {
        int ItemSell(int qty);
    }
    public interface IItemDisenchantable
    {
        void ItemDisenchant();
    }


        
}