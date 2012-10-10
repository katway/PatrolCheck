// File:    详细巡检任务.cs
// Author:  John
// Created: 2012年10月8日 10:27:04
// Purpose: Definition of Class 详细巡检任务

using System;

public class 详细巡检任务
{
   public long 编号;
   public string 名字;
   public string 别名;
   public long 岗位;
   public long 路线;
   public DateTime 开始时间;
   public DateTime 持续时间;
   public DateTime 结束时间;
   public int 周期;
   public string 周期单位;
   public DateTime 事务生效时间;
   public DateTime 事务失效时间;
   
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