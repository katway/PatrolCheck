// File:    总公司.cs
// Author:  John
// Created: 2012年10月8日 10:27:04
// Purpose: Definition of Class 总公司

using System;

public class 总公司
{
   public int 编号;
   public string 名字;
   public string 别名;
   
   public System.Collections.Generic.List<厂区> 厂区;
   
   /// <summary>
   /// Property for collection of 厂区
   /// </summary>
   /// <pdGenerated>Default opposite class collection property</pdGenerated>
   public System.Collections.Generic.List<厂区> 厂区
   {
      get
      {
         if (厂区 == null)
            厂区 = new System.Collections.Generic.List<厂区>();
         return 厂区;
      }
      set
      {
         RemoveAll厂区();
         if (value != null)
         {
            foreach (厂区 o厂区 in value)
               Add厂区(o厂区);
         }
      }
   }
   
   /// <summary>
   /// Add a new 厂区 in the collection
   /// </summary>
   /// <pdGenerated>Default Add</pdGenerated>
   public void Add厂区(厂区 new厂区)
   {
      if (new厂区 == null)
         return;
      if (this.厂区 == null)
         this.厂区 = new System.Collections.Generic.List<厂区>();
      if (!this.厂区.Contains(new厂区))
         this.厂区.Add(new厂区);
   }
   
   /// <summary>
   /// Remove an existing 厂区 from the collection
   /// </summary>
   /// <pdGenerated>Default Remove</pdGenerated>
   public void Remove厂区(厂区 old厂区)
   {
      if (old厂区 == null)
         return;
      if (this.厂区 != null)
         if (this.厂区.Contains(old厂区))
            this.厂区.Remove(old厂区);
   }
   
   /// <summary>
   /// Remove all instances of 厂区 from the collection
   /// </summary>
   /// <pdGenerated>Default removeAll</pdGenerated>
   public void RemoveAll厂区()
   {
      if (厂区 != null)
         厂区.Clear();
   }

}