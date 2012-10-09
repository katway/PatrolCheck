// File:    Ñ²¼ìÂ·Ïß.cs
// Author:  John
// Created: 2012Äê10ÔÂ8ÈÕ 10:27:04
// Purpose: Definition of Class Ñ²¼ìÂ·Ïß

using System;

public class Ñ²¼ìÂ·Ïß
{
   public int ±àºÅ;
   public string Ãû×Ö;
   public string ±ðÃû;
   
   public System.Collections.Generic.List<Âß¼­Ñ²¼ìµã> Âß¼­Ñ²¼ìµã;
   
   /// <summary>
   /// Property for collection of Âß¼­Ñ²¼ìµã
   /// </summary>
   /// <pdGenerated>Default opposite class collection property</pdGenerated>
   public System.Collections.Generic.List<Âß¼­Ñ²¼ìµã> Âß¼­Ñ²¼ìµã
   {
      get
      {
         if (Âß¼­Ñ²¼ìµã == null)
            Âß¼­Ñ²¼ìµã = new System.Collections.Generic.List<Âß¼­Ñ²¼ìµã>();
         return Âß¼­Ñ²¼ìµã;
      }
      set
      {
         RemoveAllÂß¼­Ñ²¼ìµã();
         if (value != null)
         {
            foreach (Âß¼­Ñ²¼ìµã oÂß¼­Ñ²¼ìµã in value)
               AddÂß¼­Ñ²¼ìµã(oÂß¼­Ñ²¼ìµã);
         }
      }
   }
   
   /// <summary>
   /// Add a new Âß¼­Ñ²¼ìµã in the collection
   /// </summary>
   /// <pdGenerated>Default Add</pdGenerated>
   public void AddÂß¼­Ñ²¼ìµã(Âß¼­Ñ²¼ìµã newÂß¼­Ñ²¼ìµã)
   {
      if (newÂß¼­Ñ²¼ìµã == null)
         return;
      if (this.Âß¼­Ñ²¼ìµã == null)
         this.Âß¼­Ñ²¼ìµã = new System.Collections.Generic.List<Âß¼­Ñ²¼ìµã>();
      if (!this.Âß¼­Ñ²¼ìµã.Contains(newÂß¼­Ñ²¼ìµã))
         this.Âß¼­Ñ²¼ìµã.Add(newÂß¼­Ñ²¼ìµã);
   }
   
   /// <summary>
   /// Remove an existing Âß¼­Ñ²¼ìµã from the collection
   /// </summary>
   /// <pdGenerated>Default Remove</pdGenerated>
   public void RemoveÂß¼­Ñ²¼ìµã(Âß¼­Ñ²¼ìµã oldÂß¼­Ñ²¼ìµã)
   {
      if (oldÂß¼­Ñ²¼ìµã == null)
         return;
      if (this.Âß¼­Ñ²¼ìµã != null)
         if (this.Âß¼­Ñ²¼ìµã.Contains(oldÂß¼­Ñ²¼ìµã))
            this.Âß¼­Ñ²¼ìµã.Remove(oldÂß¼­Ñ²¼ìµã);
   }
   
   /// <summary>
   /// Remove all instances of Âß¼­Ñ²¼ìµã from the collection
   /// </summary>
   /// <pdGenerated>Default removeAll</pdGenerated>
   public void RemoveAllÂß¼­Ñ²¼ìµã()
   {
      if (Âß¼­Ñ²¼ìµã != null)
         Âß¼­Ñ²¼ìµã.Clear();
   }

}