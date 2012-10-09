// File:    物理巡检点.cs
// Author:  John
// Created: 2012年10月8日 10:27:04
// Purpose: Definition of Class 物理巡检点

using System;

public class 物理巡检点
{
   public long 编号;
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
   public System.Collections.Generic.List<逻辑巡检点> 逻辑巡检点;
   
   /// <summary>
   /// Property for collection of 逻辑巡检点
   /// </summary>
   /// <pdGenerated>Default opposite class collection property</pdGenerated>
   public System.Collections.Generic.List<逻辑巡检点> 逻辑巡检点
   {
      get
      {
         if (逻辑巡检点 == null)
            逻辑巡检点 = new System.Collections.Generic.List<逻辑巡检点>();
         return 逻辑巡检点;
      }
      set
      {
         RemoveAll逻辑巡检点();
         if (value != null)
         {
            foreach (逻辑巡检点 o逻辑巡检点 in value)
               Add逻辑巡检点(o逻辑巡检点);
         }
      }
   }
   
   /// <summary>
   /// Add a new 逻辑巡检点 in the collection
   /// </summary>
   /// <pdGenerated>Default Add</pdGenerated>
   public void Add逻辑巡检点(逻辑巡检点 new逻辑巡检点)
   {
      if (new逻辑巡检点 == null)
         return;
      if (this.逻辑巡检点 == null)
         this.逻辑巡检点 = new System.Collections.Generic.List<逻辑巡检点>();
      if (!this.逻辑巡检点.Contains(new逻辑巡检点))
         this.逻辑巡检点.Add(new逻辑巡检点);
   }
   
   /// <summary>
   /// Remove an existing 逻辑巡检点 from the collection
   /// </summary>
   /// <pdGenerated>Default Remove</pdGenerated>
   public void Remove逻辑巡检点(逻辑巡检点 old逻辑巡检点)
   {
      if (old逻辑巡检点 == null)
         return;
      if (this.逻辑巡检点 != null)
         if (this.逻辑巡检点.Contains(old逻辑巡检点))
            this.逻辑巡检点.Remove(old逻辑巡检点);
   }
   
   /// <summary>
   /// Remove all instances of 逻辑巡检点 from the collection
   /// </summary>
   /// <pdGenerated>Default removeAll</pdGenerated>
   public void RemoveAll逻辑巡检点()
   {
      if (逻辑巡检点 != null)
         逻辑巡检点.Clear();
   }

}