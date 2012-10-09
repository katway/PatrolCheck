// File:    巡检计划.cs
// Author:  John
// Created: 2012年10月8日 10:27:04
// Purpose: Definition of Class 巡检计划

using System;

public class 巡检计划
{
   public int 编号;
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
   
   public System.Collections.Generic.List<详细巡检任务> 详细巡检任务;
   
   /// <summary>
   /// Property for collection of 详细巡检任务
   /// </summary>
   /// <pdGenerated>Default opposite class collection property</pdGenerated>
   public System.Collections.Generic.List<详细巡检任务> 详细巡检任务
   {
      get
      {
         if (详细巡检任务 == null)
            详细巡检任务 = new System.Collections.Generic.List<详细巡检任务>();
         return 详细巡检任务;
      }
      set
      {
         RemoveAll详细巡检任务();
         if (value != null)
         {
            foreach (详细巡检任务 o详细巡检任务 in value)
               Add详细巡检任务(o详细巡检任务);
         }
      }
   }
   
   /// <summary>
   /// Add a new 详细巡检任务 in the collection
   /// </summary>
   /// <pdGenerated>Default Add</pdGenerated>
   public void Add详细巡检任务(详细巡检任务 new详细巡检任务)
   {
      if (new详细巡检任务 == null)
         return;
      if (this.详细巡检任务 == null)
         this.详细巡检任务 = new System.Collections.Generic.List<详细巡检任务>();
      if (!this.详细巡检任务.Contains(new详细巡检任务))
         this.详细巡检任务.Add(new详细巡检任务);
   }
   
   /// <summary>
   /// Remove an existing 详细巡检任务 from the collection
   /// </summary>
   /// <pdGenerated>Default Remove</pdGenerated>
   public void Remove详细巡检任务(详细巡检任务 old详细巡检任务)
   {
      if (old详细巡检任务 == null)
         return;
      if (this.详细巡检任务 != null)
         if (this.详细巡检任务.Contains(old详细巡检任务))
            this.详细巡检任务.Remove(old详细巡检任务);
   }
   
   /// <summary>
   /// Remove all instances of 详细巡检任务 from the collection
   /// </summary>
   /// <pdGenerated>Default removeAll</pdGenerated>
   public void RemoveAll详细巡检任务()
   {
      if (详细巡检任务 != null)
         详细巡检任务.Clear();
   }

}