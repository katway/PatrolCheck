// File:    巡检点纪录.cs
// Author:  John
// Created: 2012年10月8日 10:27:04
// Purpose: Definition of Class 巡检点纪录

using System;

public class 巡检点纪录
{
   public long 编号;
   public DateTime 开始时间;
   public DateTime 结束时间;
   public DateTime 持续时间;
   
   public System.Collections.Generic.List<巡检项纪录> 巡检项纪录;
   
   /// <summary>
   /// Property for collection of 巡检项纪录
   /// </summary>
   /// <pdGenerated>Default opposite class collection property</pdGenerated>
   public System.Collections.Generic.List<巡检项纪录> 巡检项纪录
   {
      get
      {
         if (巡检项纪录 == null)
            巡检项纪录 = new System.Collections.Generic.List<巡检项纪录>();
         return 巡检项纪录;
      }
      set
      {
         RemoveAll巡检项纪录();
         if (value != null)
         {
            foreach (巡检项纪录 o巡检项纪录 in value)
               Add巡检项纪录(o巡检项纪录);
         }
      }
   }
   
   /// <summary>
   /// Add a new 巡检项纪录 in the collection
   /// </summary>
   /// <pdGenerated>Default Add</pdGenerated>
   public void Add巡检项纪录(巡检项纪录 new巡检项纪录)
   {
      if (new巡检项纪录 == null)
         return;
      if (this.巡检项纪录 == null)
         this.巡检项纪录 = new System.Collections.Generic.List<巡检项纪录>();
      if (!this.巡检项纪录.Contains(new巡检项纪录))
         this.巡检项纪录.Add(new巡检项纪录);
   }
   
   /// <summary>
   /// Remove an existing 巡检项纪录 from the collection
   /// </summary>
   /// <pdGenerated>Default Remove</pdGenerated>
   public void Remove巡检项纪录(巡检项纪录 old巡检项纪录)
   {
      if (old巡检项纪录 == null)
         return;
      if (this.巡检项纪录 != null)
         if (this.巡检项纪录.Contains(old巡检项纪录))
            this.巡检项纪录.Remove(old巡检项纪录);
   }
   
   /// <summary>
   /// Remove all instances of 巡检项纪录 from the collection
   /// </summary>
   /// <pdGenerated>Default removeAll</pdGenerated>
   public void RemoveAll巡检项纪录()
   {
      if (巡检项纪录 != null)
         巡检项纪录.Clear();
   }

}