﻿///////////////////////////////////////////////////////////////////////////////
//
// This file was automatically generated by RANOREX.
// DO NOT MODIFY THIS FILE! It is regenerated by the designer.
// All your modifications will be lost!
// http://www.ranorex.com
//
///////////////////////////////////////////////////////////////////////////////

using System;
using System.Collections.Generic;
using System.Text;
using System.Drawing;
using Ranorex;
using Ranorex.Core;
using Ranorex.Core.Repository;
using Ranorex.Core.Testing;

namespace General
{
#pragma warning disable 0436 //(CS0436) The type 'type' in 'assembly' conflicts with the imported type 'type2' in 'assembly'. Using the type defined in 'assembly'.
    /// <summary>
    /// The class representing the GeneralRepository element repository.
    /// </summary>
    [System.CodeDom.Compiler.GeneratedCode("Ranorex", "8.0")]
    [RepositoryFolder("ed1c523b-ba79-4bb7-9d6f-baa76dcc9580")]
    public partial class GeneralRepository : RepoGenBaseFolder
    {
        static GeneralRepository instance = new GeneralRepository();
        GeneralRepositoryFolders.ConnectionManagerAppFolder _connectionmanager;

        /// <summary>
        /// Gets the singleton class instance representing the GeneralRepository element repository.
        /// </summary>
        [RepositoryFolder("ed1c523b-ba79-4bb7-9d6f-baa76dcc9580")]
        public static GeneralRepository Instance
        {
            get { return instance; }
        }

        /// <summary>
        /// Repository class constructor.
        /// </summary>
        public GeneralRepository() 
            : base("GeneralRepository", "/", null, 0, false, "ed1c523b-ba79-4bb7-9d6f-baa76dcc9580", ".\\RepositoryImages\\GeneralRepositoryed1c523b.rximgres")
        {
            _connectionmanager = new GeneralRepositoryFolders.ConnectionManagerAppFolder(this);
        }

#region Variables

#endregion

        /// <summary>
        /// The Self item info.
        /// </summary>
        [RepositoryItemInfo("ed1c523b-ba79-4bb7-9d6f-baa76dcc9580")]
        public virtual RepoItemInfo SelfInfo
        {
            get
            {
                return _selfInfo;
            }
        }

        /// <summary>
        /// The ConnectionManager folder.
        /// </summary>
        [RepositoryFolder("edd04951-bbdf-4304-893c-80402c3e8a5a")]
        public virtual GeneralRepositoryFolders.ConnectionManagerAppFolder ConnectionManager
        {
            get { return _connectionmanager; }
        }
    }

    /// <summary>
    /// Inner folder classes.
    /// </summary>
    [System.CodeDom.Compiler.GeneratedCode("Ranorex", "8.0")]
    public partial class GeneralRepositoryFolders
    {
        /// <summary>
        /// The ConnectionManagerAppFolder folder.
        /// </summary>
        [RepositoryFolder("edd04951-bbdf-4304-893c-80402c3e8a5a")]
        public partial class ConnectionManagerAppFolder : RepoGenBaseFolder
        {

            /// <summary>
            /// Creates a new ConnectionManager  folder.
            /// </summary>
            public ConnectionManagerAppFolder(RepoGenBaseFolder parentFolder) :
                    base("ConnectionManager", "/dom[@domain='testgames.be']", parentFolder, 30000, null, false, "edd04951-bbdf-4304-893c-80402c3e8a5a", "")
            {
            }

            /// <summary>
            /// The Self item.
            /// </summary>
            [RepositoryItem("edd04951-bbdf-4304-893c-80402c3e8a5a")]
            public virtual Ranorex.WebDocument Self
            {
                get
                {
                    return _selfInfo.CreateAdapter<Ranorex.WebDocument>(true);
                }
            }

            /// <summary>
            /// The Self item info.
            /// </summary>
            [RepositoryItemInfo("edd04951-bbdf-4304-893c-80402c3e8a5a")]
            public virtual RepoItemInfo SelfInfo
            {
                get
                {
                    return _selfInfo;
                }
            }
        }

    }
#pragma warning restore 0436
}