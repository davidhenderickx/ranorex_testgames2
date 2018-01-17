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

namespace Menu
{
#pragma warning disable 0436 //(CS0436) The type 'type' in 'assembly' conflicts with the imported type 'type2' in 'assembly'. Using the type defined in 'assembly'.
    /// <summary>
    /// The class representing the MenuRepository element repository.
    /// </summary>
    [System.CodeDom.Compiler.GeneratedCode("Ranorex", "8.0")]
    [RepositoryFolder("d0618479-6184-42b2-a316-675c3190a689")]
    public partial class MenuRepository : RepoGenBaseFolder
    {
        static MenuRepository instance = new MenuRepository();
        MenuRepositoryFolders.ConnectionManagerAppFolder _connectionmanager;

        /// <summary>
        /// Gets the singleton class instance representing the MenuRepository element repository.
        /// </summary>
        [RepositoryFolder("d0618479-6184-42b2-a316-675c3190a689")]
        public static MenuRepository Instance
        {
            get { return instance; }
        }

        /// <summary>
        /// Repository class constructor.
        /// </summary>
        public MenuRepository() 
            : base("MenuRepository", "/", null, 0, false, "d0618479-6184-42b2-a316-675c3190a689", ".\\RepositoryImages\\MenuRepositoryd0618479.rximgres")
        {
            _connectionmanager = new MenuRepositoryFolders.ConnectionManagerAppFolder(this);
        }

#region Variables

#endregion

        /// <summary>
        /// The Self item info.
        /// </summary>
        [RepositoryItemInfo("d0618479-6184-42b2-a316-675c3190a689")]
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
        [RepositoryFolder("dd3bde23-5a05-4221-847c-4f98b05e3550")]
        public virtual MenuRepositoryFolders.ConnectionManagerAppFolder ConnectionManager
        {
            get { return _connectionmanager; }
        }
    }

    /// <summary>
    /// Inner folder classes.
    /// </summary>
    [System.CodeDom.Compiler.GeneratedCode("Ranorex", "8.0")]
    public partial class MenuRepositoryFolders
    {
        /// <summary>
        /// The ConnectionManagerAppFolder folder.
        /// </summary>
        [RepositoryFolder("dd3bde23-5a05-4221-847c-4f98b05e3550")]
        public partial class ConnectionManagerAppFolder : RepoGenBaseFolder
        {
            RepoItemInfo _logoutInfo;

            /// <summary>
            /// Creates a new ConnectionManager  folder.
            /// </summary>
            public ConnectionManagerAppFolder(RepoGenBaseFolder parentFolder) :
                    base("ConnectionManager", "/dom[@domain='testgames.be']", parentFolder, 30000, null, false, "dd3bde23-5a05-4221-847c-4f98b05e3550", "")
            {
                _logoutInfo = new RepoItemInfo(this, "Logout", ".//a[#'logout']", 30000, null, "73efc12b-b400-42bb-a53b-efb7a6beafc0");
            }

            /// <summary>
            /// The Self item.
            /// </summary>
            [RepositoryItem("dd3bde23-5a05-4221-847c-4f98b05e3550")]
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
            [RepositoryItemInfo("dd3bde23-5a05-4221-847c-4f98b05e3550")]
            public virtual RepoItemInfo SelfInfo
            {
                get
                {
                    return _selfInfo;
                }
            }

            /// <summary>
            /// The Logout item.
            /// </summary>
            [RepositoryItem("73efc12b-b400-42bb-a53b-efb7a6beafc0")]
            public virtual Ranorex.ATag Logout
            {
                get
                {
                    return _logoutInfo.CreateAdapter<Ranorex.ATag>(true);
                }
            }

            /// <summary>
            /// The Logout item info.
            /// </summary>
            [RepositoryItemInfo("73efc12b-b400-42bb-a53b-efb7a6beafc0")]
            public virtual RepoItemInfo LogoutInfo
            {
                get
                {
                    return _logoutInfo;
                }
            }
        }

    }
#pragma warning restore 0436
}