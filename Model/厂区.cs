// File:    厂区.cs
// Author:  John
// Created: 2012年10月8日 10:27:04
// Purpose: Definition of Class 厂区

using System;

public class 厂区
{
   public int 编号;
   public string 名字;
   public string 别名;
   
   public System.Collections.Generic.List<岗位> 岗位;
   
   /// <summary>
   /// Property for collection of 岗位
   /// </summary>
   /// <pdGenerated>Default opposite class collection property</pdGenerated>
   public System.Collections.Generic.List<岗位> 岗位
   {
      get
      {
         if (岗位 == null)
            岗位 = new System.Collections.Generic.List<岗位>();
         return 岗位;
      }
      set
      {
         RemoveAll岗位();
         if (value != null)
         {
            foreach (岗位 o岗位 in value)
               Add岗位(o岗位);
         }
      }
   }
   
   /// <summary>
   /// Add a new 岗位 in the collection
   /// </summary>
   /// <pdGenerated>Default Add</pdGenerated>
   public void Add岗位(岗位 new岗位)
   {
      if (new岗位 == null)
         return;
      if (this.岗位 == null)
         this.岗位 = new System.Collections.Generic.List<岗位>();
      if (!this.岗位.Contains(new岗位))
         this.岗位.Add(new岗位);
   }
   
   /// <summary>
   /// Remove an existing 岗位 from the collection
   /// </summary>
   /// <pdGenerated>Default Remove</pdGenerated>
   public void Remove岗位(岗位 old岗位)
   {
      if (old岗位 == null)
         return;
      if (this.岗位 != null)
         if (this.岗位.Contains(old岗位))
            this.岗位.Remove(old岗位);
   }
   
   /// <summary>
   /// Remove all instances of 岗位 from the collection
   /// </summary>
   /// <pdGenerated>Default removeAll</pdGenerated>
   public void RemoveAll岗位()
   {
      if (岗位 != null)
         岗位.Clear();
   }
   public System.Collections.Generic.List<巡检路线> 巡检路线;
   
   /// <summary>
   /// Property for collection of 巡检路线
   /// </summary>
   /// <pdGenerated>Default opposite class collection property</pdGenerated>
   public System.Collections.Generic.List<巡检路线> 巡检路线
   {
      get
      {
         if (巡检路线 == null)
            巡检路线 = new System.Collections.Generic.List<巡检路线>();
         return 巡检路线;
      }
      set
      {
         RemoveAll巡检路线();
         if (value != null)
         {
            foreach (巡检路线 o巡检路线 in value)
               Add巡检路线(o巡检路线);
         }
      }
   }
   
   /// <summary>
   /// Add a new 巡检路线 in the collection
   /// </summary>
   /// <pdGenerated>Default Add</pdGenerated>
   public void Add巡检路线(巡检路线 new巡检路线)
   {
      if (new巡检路线 == null)
         return;
      if (this.巡检路线 == null)
         this.巡检路线 = new System.Collections.Generic.List<巡检路线>();
      if (!this.巡检路线.Contains(new巡检路线))
         this.巡检路线.Add(new巡检路线);
   }
   
   /// <summary>
   /// Remove an existing 巡检路线 from the collection
   /// </summary>
   /// <pdGenerated>Default Remove</pdGenerated>
   public void Remove巡检路线(巡检路线 old巡检路线)
   {
      if (old巡检路线 == null)
         return;
      if (this.巡检路线 != null)
         if (this.巡检路线.Contains(old巡检路线))
            this.巡检路线.Remove(old巡检路线);
   }
   
   /// <summary>
   /// Remove all instances of 巡检路线 from the collection
   /// </summary>
   /// <pdGenerated>Default removeAll</pdGenerated>
   public void RemoveAll巡检路线()
   {
      if (巡检路线 != null)
         巡检路线.Clear();
   }
   public System.Collections.Generic.List<装置> 装置;
   
   /// <summary>
   /// Property for collection of 装置
   /// </summary>
   /// <pdGenerated>Default opposite class collection property</pdGenerated>
   public System.Collections.Generic.List<装置> 装置
   {
      get
      {
         if (装置 == null)
            装置 = new System.Collections.Generic.List<装置>();
         return 装置;
      }
      set
      {
         RemoveAll装置();
         if (value != null)
         {
            foreach (装置 o装置 in value)
               Add装置(o装置);
         }
      }
   }
   
   /// <summary>
   /// Add a new 装置 in the collection
   /// </summary>
   /// <pdGenerated>Default Add</pdGenerated>
   public void Add装置(装置 new装置)
   {
      if (new装置 == null)
         return;
      if (this.装置 == null)
         this.装置 = new System.Collections.Generic.List<装置>();
      if (!this.装置.Contains(new装置))
         this.装置.Add(new装置);
   }
   
   /// <summary>
   /// Remove an existing 装置 from the collection
   /// </summary>
   /// <pdGenerated>Default Remove</pdGenerated>
   public void Remove装置(装置 old装置)
   {
      if (old装置 == null)
         return;
      if (this.装置 != null)
         if (this.装置.Contains(old装置))
            this.装置.Remove(old装置);
   }
   
   /// <summary>
   /// Remove all instances of 装置 from the collection
   /// </summary>
   /// <pdGenerated>Default removeAll</pdGenerated>
   public void RemoveAll装置()
   {
      if (装置 != null)
         装置.Clear();
   }
   public System.Collections.Generic.List<员工> 员工;
   
   /// <summary>
   /// Property for collection of 员工
   /// </summary>
   /// <pdGenerated>Default opposite class collection property</pdGenerated>
   public System.Collections.Generic.List<员工> 员工
   {
      get
      {
         if (员工 == null)
            员工 = new System.Collections.Generic.List<员工>();
         return 员工;
      }
      set
      {
         RemoveAll员工();
         if (value != null)
         {
            foreach (员工 o员工 in value)
               Add员工(o员工);
         }
      }
   }
   
   /// <summary>
   /// Add a new 员工 in the collection
   /// </summary>
   /// <pdGenerated>Default Add</pdGenerated>
   public void Add员工(员工 new员工)
   {
      if (new员工 == null)
         return;
      if (this.员工 == null)
         this.员工 = new System.Collections.Generic.List<员工>();
      if (!this.员工.Contains(new员工))
         this.员工.Add(new员工);
   }
   
   /// <summary>
   /// Remove an existing 员工 from the collection
   /// </summary>
   /// <pdGenerated>Default Remove</pdGenerated>
   public void Remove员工(员工 old员工)
   {
      if (old员工 == null)
         return;
      if (this.员工 != null)
         if (this.员工.Contains(old员工))
            this.员工.Remove(old员工);
   }
   
   /// <summary>
   /// Remove all instances of 员工 from the collection
   /// </summary>
   /// <pdGenerated>Default removeAll</pdGenerated>
   public void RemoveAll员工()
   {
      if (员工 != null)
         员工.Clear();
   }
   public System.Collections.Generic.List<物理巡检点> 物理巡检点;
   
   /// <summary>
   /// Property for collection of 物理巡检点
   /// </summary>
   /// <pdGenerated>Default opposite class collection property</pdGenerated>
   public System.Collections.Generic.List<物理巡检点> 物理巡检点
   {
      get
      {
         if (物理巡检点 == null)
            物理巡检点 = new System.Collections.Generic.List<物理巡检点>();
         return 物理巡检点;
      }
      set
      {
         RemoveAll物理巡检点();
         if (value != null)
         {
            foreach (物理巡检点 o物理巡检点 in value)
               Add物理巡检点(o物理巡检点);
         }
      }
   }
   
   /// <summary>
   /// Add a new 物理巡检点 in the collection
   /// </summary>
   /// <pdGenerated>Default Add</pdGenerated>
   public void Add物理巡检点(物理巡检点 new物理巡检点)
   {
      if (new物理巡检点 == null)
         return;
      if (this.物理巡检点 == null)
         this.物理巡检点 = new System.Collections.Generic.List<物理巡检点>();
      if (!this.物理巡检点.Contains(new物理巡检点))
         this.物理巡检点.Add(new物理巡检点);
   }
   
   /// <summary>
   /// Remove an existing 物理巡检点 from the collection
   /// </summary>
   /// <pdGenerated>Default Remove</pdGenerated>
   public void Remove物理巡检点(物理巡检点 old物理巡检点)
   {
      if (old物理巡检点 == null)
         return;
      if (this.物理巡检点 != null)
         if (this.物理巡检点.Contains(old物理巡检点))
            this.物理巡检点.Remove(old物理巡检点);
   }
   
   /// <summary>
   /// Remove all instances of 物理巡检点 from the collection
   /// </summary>
   /// <pdGenerated>Default removeAll</pdGenerated>
   public void RemoveAll物理巡检点()
   {
      if (物理巡检点 != null)
         物理巡检点.Clear();
   }

}