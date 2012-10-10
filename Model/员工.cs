// File:    员工.cs
// Author:  John
// Created: 2012年10月8日 10:27:04
// Purpose: Definition of Class 员工

using System;

public class 员工
{
   public int 编号;
   public string 名字;
   public string 别名;
   
   public System.Collections.Generic.List<岗位员工> 岗位员工;
   
   /// <summary>
   /// Property for collection of 岗位员工
   /// </summary>
   /// <pdGenerated>Default opposite class collection property</pdGenerated>
   public System.Collections.Generic.List<岗位员工> 岗位员工
   {
      get
      {
         if (岗位员工 == null)
            岗位员工 = new System.Collections.Generic.List<岗位员工>();
         return 岗位员工;
      }
      set
      {
         RemoveAll岗位员工();
         if (value != null)
         {
            foreach (岗位员工 o岗位员工 in value)
               Add岗位员工(o岗位员工);
         }
      }
   }
   
   /// <summary>
   /// Add a new 岗位员工 in the collection
   /// </summary>
   /// <pdGenerated>Default Add</pdGenerated>
   public void Add岗位员工(岗位员工 new岗位员工)
   {
      if (new岗位员工 == null)
         return;
      if (this.岗位员工 == null)
         this.岗位员工 = new System.Collections.Generic.List<岗位员工>();
      if (!this.岗位员工.Contains(new岗位员工))
         this.岗位员工.Add(new岗位员工);
   }
   
   /// <summary>
   /// Remove an existing 岗位员工 from the collection
   /// </summary>
   /// <pdGenerated>Default Remove</pdGenerated>
   public void Remove岗位员工(岗位员工 old岗位员工)
   {
      if (old岗位员工 == null)
         return;
      if (this.岗位员工 != null)
         if (this.岗位员工.Contains(old岗位员工))
            this.岗位员工.Remove(old岗位员工);
   }
   
   /// <summary>
   /// Remove all instances of 岗位员工 from the collection
   /// </summary>
   /// <pdGenerated>Default removeAll</pdGenerated>
   public void RemoveAll岗位员工()
   {
      if (岗位员工 != null)
         岗位员工.Clear();
   }
   public System.Collections.Generic.List<巡检计划> 巡检计划;
   
   /// <summary>
   /// Property for collection of 巡检计划
   /// </summary>
   /// <pdGenerated>Default opposite class collection property</pdGenerated>
   public System.Collections.Generic.List<巡检计划> 巡检计划
   {
      get
      {
         if (巡检计划 == null)
            巡检计划 = new System.Collections.Generic.List<巡检计划>();
         return 巡检计划;
      }
      set
      {
         RemoveAll巡检计划();
         if (value != null)
         {
            foreach (巡检计划 o巡检计划 in value)
               Add巡检计划(o巡检计划);
         }
      }
   }
   
   /// <summary>
   /// Add a new 巡检计划 in the collection
   /// </summary>
   /// <pdGenerated>Default Add</pdGenerated>
   public void Add巡检计划(巡检计划 new巡检计划)
   {
      if (new巡检计划 == null)
         return;
      if (this.巡检计划 == null)
         this.巡检计划 = new System.Collections.Generic.List<巡检计划>();
      if (!this.巡检计划.Contains(new巡检计划))
         this.巡检计划.Add(new巡检计划);
   }
   
   /// <summary>
   /// Remove an existing 巡检计划 from the collection
   /// </summary>
   /// <pdGenerated>Default Remove</pdGenerated>
   public void Remove巡检计划(巡检计划 old巡检计划)
   {
      if (old巡检计划 == null)
         return;
      if (this.巡检计划 != null)
         if (this.巡检计划.Contains(old巡检计划))
            this.巡检计划.Remove(old巡检计划);
   }
   
   /// <summary>
   /// Remove all instances of 巡检计划 from the collection
   /// </summary>
   /// <pdGenerated>Default removeAll</pdGenerated>
   public void RemoveAll巡检计划()
   {
      if (巡检计划 != null)
         巡检计划.Clear();
   }
   public System.Collections.Generic.List<巡检路线纪录> 巡检路线纪录;
   
   /// <summary>
   /// Property for collection of 巡检路线纪录
   /// </summary>
   /// <pdGenerated>Default opposite class collection property</pdGenerated>
   public System.Collections.Generic.List<巡检路线纪录> 巡检路线纪录
   {
      get
      {
         if (巡检路线纪录 == null)
            巡检路线纪录 = new System.Collections.Generic.List<巡检路线纪录>();
         return 巡检路线纪录;
      }
      set
      {
         RemoveAll巡检路线纪录();
         if (value != null)
         {
            foreach (巡检路线纪录 o巡检路线纪录 in value)
               Add巡检路线纪录(o巡检路线纪录);
         }
      }
   }
   
   /// <summary>
   /// Add a new 巡检路线纪录 in the collection
   /// </summary>
   /// <pdGenerated>Default Add</pdGenerated>
   public void Add巡检路线纪录(巡检路线纪录 new巡检路线纪录)
   {
      if (new巡检路线纪录 == null)
         return;
      if (this.巡检路线纪录 == null)
         this.巡检路线纪录 = new System.Collections.Generic.List<巡检路线纪录>();
      if (!this.巡检路线纪录.Contains(new巡检路线纪录))
         this.巡检路线纪录.Add(new巡检路线纪录);
   }
   
   /// <summary>
   /// Remove an existing 巡检路线纪录 from the collection
   /// </summary>
   /// <pdGenerated>Default Remove</pdGenerated>
   public void Remove巡检路线纪录(巡检路线纪录 old巡检路线纪录)
   {
      if (old巡检路线纪录 == null)
         return;
      if (this.巡检路线纪录 != null)
         if (this.巡检路线纪录.Contains(old巡检路线纪录))
            this.巡检路线纪录.Remove(old巡检路线纪录);
   }
   
   /// <summary>
   /// Remove all instances of 巡检路线纪录 from the collection
   /// </summary>
   /// <pdGenerated>Default removeAll</pdGenerated>
   public void RemoveAll巡检路线纪录()
   {
      if (巡检路线纪录 != null)
         巡检路线纪录.Clear();
   }

}