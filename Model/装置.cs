// File:    装置.cs
// Author:  John
// Created: 2012年10月8日 10:27:04
// Purpose: Definition of Class 装置

using System;

public class 装置
{
   public int 编号;
   public string 名字;
   public string 别名;
   
   public System.Collections.Generic.List<巡检项目> 巡检项目;
   
   /// <summary>
   /// Property for collection of 巡检项目
   /// </summary>
   /// <pdGenerated>Default opposite class collection property</pdGenerated>
   public System.Collections.Generic.List<巡检项目> 巡检项目
   {
      get
      {
         if (巡检项目 == null)
            巡检项目 = new System.Collections.Generic.List<巡检项目>();
         return 巡检项目;
      }
      set
      {
         RemoveAll巡检项目();
         if (value != null)
         {
            foreach (巡检项目 o巡检项目 in value)
               Add巡检项目(o巡检项目);
         }
      }
   }
   
   /// <summary>
   /// Add a new 巡检项目 in the collection
   /// </summary>
   /// <pdGenerated>Default Add</pdGenerated>
   public void Add巡检项目(巡检项目 new巡检项目)
   {
      if (new巡检项目 == null)
         return;
      if (this.巡检项目 == null)
         this.巡检项目 = new System.Collections.Generic.List<巡检项目>();
      if (!this.巡检项目.Contains(new巡检项目))
         this.巡检项目.Add(new巡检项目);
   }
   
   /// <summary>
   /// Remove an existing 巡检项目 from the collection
   /// </summary>
   /// <pdGenerated>Default Remove</pdGenerated>
   public void Remove巡检项目(巡检项目 old巡检项目)
   {
      if (old巡检项目 == null)
         return;
      if (this.巡检项目 != null)
         if (this.巡检项目.Contains(old巡检项目))
            this.巡检项目.Remove(old巡检项目);
   }
   
   /// <summary>
   /// Remove all instances of 巡检项目 from the collection
   /// </summary>
   /// <pdGenerated>Default removeAll</pdGenerated>
   public void RemoveAll巡检项目()
   {
      if (巡检项目 != null)
         巡检项目.Clear();
   }

}