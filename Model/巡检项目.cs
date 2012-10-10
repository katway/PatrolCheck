// File:    巡检项目.cs
// Author:  John
// Created: 2012年10月8日 10:27:04
// Purpose: Definition of Class 巡检项目

using System;

public class 巡检项目
{
    public int 编号;
    public string 名字;
    public string 别名;
    public int 值类型;
    public string 备注;

    private System.Collections.Generic.List<巡检项纪录> _巡检项纪录;

    /// <summary>
    /// Property for collection of 巡检项纪录
    /// </summary>
    /// <pdGenerated>Default opposite class collection property</pdGenerated>
    public System.Collections.Generic.List<巡检项纪录> 巡检项纪录
    {
        get
        {
            if (_巡检项纪录 == null)
                _巡检项纪录 = new System.Collections.Generic.List<巡检项纪录>();
            return _巡检项纪录;
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
        if (this._巡检项纪录 == null)
            this._巡检项纪录 = new System.Collections.Generic.List<巡检项纪录>();
        if (!this._巡检项纪录.Contains(new巡检项纪录))
            this._巡检项纪录.Add(new巡检项纪录);
    }

    /// <summary>
    /// Remove an existing 巡检项纪录 from the collection
    /// </summary>
    /// <pdGenerated>Default Remove</pdGenerated>
    public void Remove巡检项纪录(巡检项纪录 old巡检项纪录)
    {
        if (old巡检项纪录 == null)
            return;
        if (this._巡检项纪录 != null)
            if (this._巡检项纪录.Contains(old巡检项纪录))
                this._巡检项纪录.Remove(old巡检项纪录);
    }

    /// <summary>
    /// Remove all instances of 巡检项纪录 from the collection
    /// </summary>
    /// <pdGenerated>Default removeAll</pdGenerated>
    public void RemoveAll巡检项纪录()
    {
        if (_巡检项纪录 != null)
            _巡检项纪录.Clear();
    }

}