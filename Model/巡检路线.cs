// File:    巡检路线.cs
// Author:  John
// Created: 2012年10月8日 10:27:04
// Purpose: Definition of Class 巡检路线

using System;

public class 巡检路线
{
   public int 编号;
   public string 名字;
   public string 别名;
   
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