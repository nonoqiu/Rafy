//------------------------------------------------------------------------------
// <auto-generated>
//     本文件代码自动生成。用于实现强类型接口，方便应用层使用。
//     版本号:1.6.0
//
//     请勿修改，否则在重新生成时，所有修改会丢失。
// </auto-generated>
//------------------------------------------------------------------------------

using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using Rafy;
using Rafy.ComponentModel;
using Rafy.Data;
using Rafy.Domain;
using Rafy.Domain.ORM;

namespace Rafy.RBAC.Old
{
    partial class UserList
    {
        #region 强类型公有接口

        /// <summary>
        /// 获取或设置指定位置的实体。
        /// </summary>
        /// <param name="index"></param>
        /// <returns></returns>
        public new User this[int index]
        {
            get
            {
                return base[index] as User;
            }
            set
            {
                base[index] = value;
            }
        }

        /// <summary>
        /// 获取本实体列表的迭代器。
        /// </summary>
        /// <returns></returns>
        [DebuggerStepThrough]
        public new IEnumerator<User> GetEnumerator()
        {
            return new EntityListEnumerator<User>(this);
        }

        /// <summary>
        /// 返回子实体的强类型迭代接口，方便使用 Linq To Object 操作。
        /// </summary>
        /// <returns></returns>
        [DebuggerStepThrough]
        public IEnumerable<User> Concrete()
        {
            return this.Cast<User>();
        }

        /// <summary>
        /// 添加指定的实体到集合中。
        /// </summary>
        [DebuggerStepThrough]
        public void Add(User entity)
        {
            base.Add(entity);
        }

        /// <summary>
        /// 判断本集合是否包含指定的实体。
        /// </summary>
        /// <returns></returns>
        [DebuggerStepThrough]
        public bool Contains(User entity)
        {
            return base.Contains(entity);
        }

        /// <summary>
        /// 判断指定的实体在本集合中的索引号。
        /// </summary>
        /// <returns></returns>
        [DebuggerStepThrough]
        public int IndexOf(User entity)
        {
            return base.IndexOf(entity);
        }

        /// <summary>
        /// 在指定的位置插入实体。
        /// </summary>
        /// <returns></returns>
        [DebuggerStepThrough]
        public void Insert(int index, User entity)
        {
            base.Insert(index, entity);
        }

        /// <summary>
        /// 在集合中删除指定的实体。返回是否成功删除。
        /// </summary>
        /// <returns></returns>
        [DebuggerStepThrough]
        public bool Remove(User entity)
        {
            return base.Remove(entity);
        }

        #endregion
    }

    partial class UserRepository
    {
        #region 私有方法，本类内部使用

        /// <summary>
        /// 创建一个实体类的 Linq 查询器
        /// </summary>
        /// <returns></returns>
        [DebuggerStepThrough]
        private IQueryable<User> CreateLinqQuery()
        {
            return base.CreateLinqQuery<User>();
        }

        #endregion

        #region 强类型公有接口

        /// <summary>
        /// 创建一个新的实体。
        /// </summary>
        /// <returns></returns>
        [DebuggerStepThrough]
        public new User New()
        {
            return base.New() as User;
        }

        /// <summary>
        /// 创建一个全新的列表
        /// </summary>
        /// <returns></returns>
        [DebuggerStepThrough]
        public new UserList NewList()
        {
            return base.NewList() as UserList;
        }

        /// <summary>
        /// 优先使用缓存中的数据来通过 Id 获取指定的实体对象
        /// 
        /// 如果该实体的缓存没有打开，则本方法会直接调用 GetById 并返回结果。
        /// 如果缓存中没有这些数据，则本方法同时会把数据缓存起来。
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        [DebuggerStepThrough]
        public new User CacheById(object id)
        {
            return base.CacheById(id) as User;
        }

        /// <summary>
        /// 优先使用缓存中的数据来查询所有的实体类
        /// 
        /// 如果该实体的缓存没有打开，则本方法会直接调用 GetAll 并返回结果。
        /// 如果缓存中没有这些数据，则本方法同时会把数据缓存起来。
        /// </summary>
        /// <returns></returns>
        [DebuggerStepThrough]
        public new UserList CacheAll()
        {
            return base.CacheAll() as UserList;
        }

        /// <summary>
        /// 通过Id在数据层中查询指定的对象
        /// </summary>
        /// <param name="id"></param>
        /// <param name="eagerLoad">需要贪婪加载的属性。</param>
        /// <returns></returns>
        [DebuggerStepThrough]
        public new User GetById(object id, EagerLoadOptions eagerLoad = null)
        {
            return base.GetById(id, eagerLoad) as User;
        }

        /// <summary>
        /// 查询第一个实体类
        /// </summary>
        /// <param name="eagerLoad">需要贪婪加载的属性。</param>
        /// <returns></returns>
        [DebuggerStepThrough]
        public new User GetFirst(EagerLoadOptions eagerLoad = null)
        {
            return base.GetFirst(eagerLoad) as User;
        }

        /// <summary>
        /// 分页查询所有的实体类
        /// </summary>
        /// <param name="paging"></param>
        /// <param name="eagerLoad">需要贪婪加载的属性。</param>
        /// <returns></returns>
        [DebuggerStepThrough]
        public new UserList GetAll(PagingInfo paging = null, EagerLoadOptions eagerLoad = null)
        {
            return base.GetAll(paging, eagerLoad) as UserList;
        }

        /// <summary>
        /// 获取指定 id 集合的实体列表。
        /// </summary>
        /// <param name="idList"></param>
        /// <param name="eagerLoad">需要贪婪加载的属性。</param>
        /// <returns></returns>
        [DebuggerStepThrough]
        public new UserList GetByIdList(object[] idList, EagerLoadOptions eagerLoad = null)
        {
            return base.GetByIdList(idList, eagerLoad) as UserList;
        }

        /// <summary>
        /// 通过组合父对象的 Id 列表，查找所有的组合子对象的集合。
        /// </summary>
        /// <param name="parentIdList"></param>
        /// <param name="paging">分页信息。</param>
        /// <param name="eagerLoad">需要贪婪加载的属性。</param>
        /// <returns></returns>
        [DebuggerStepThrough]
        public new UserList GetByParentIdList(object[] parentIdList, PagingInfo paging = null, EagerLoadOptions eagerLoad = null)
        {
            return base.GetByParentIdList(parentIdList, paging, eagerLoad) as UserList;
        }

        /// <summary>
        /// 通过父对象 Id 分页查询子对象的集合。
        /// </summary>
        /// <param name="parentId"></param>
        /// <param name="paging">分页信息。</param>
        /// <param name="eagerLoad">需要贪婪加载的属性。</param>
        /// <returns></returns>
        [DebuggerStepThrough]
        public new UserList GetByParentId(object parentId, PagingInfo paging = null, EagerLoadOptions eagerLoad = null)
        {
            return base.GetByParentId(parentId, paging, eagerLoad) as UserList;
        }
    
        /// <summary>
        /// 通过 CommonQueryCriteria 来查询实体列表。
        /// </summary>
        /// <param name="criteria">常用查询条件。</param>
        /// <returns></returns>
        [DebuggerStepThrough]
        public new UserList GetBy(CommonQueryCriteria criteria)
        {
            return base.GetBy(criteria) as UserList;
        }
    
        /// <summary>
        /// 通过 CommonQueryCriteria 来查询单一实体。
        /// </summary>
        /// <param name="criteria">常用查询条件。</param>
        /// <returns></returns>
        [DebuggerStepThrough]
        public new User GetFirstBy(CommonQueryCriteria criteria)
        {
            return base.GetFirstBy(criteria) as User;
        }

        /// <summary>
        /// 递归查找所有树型子
        /// </summary>
        /// <param name="treeIndex"></param>
        /// <param name="eagerLoad">需要贪婪加载的属性。</param>
        /// <returns></returns>
        [DebuggerStepThrough]
        public new UserList GetByTreeParentIndex(string treeIndex, EagerLoadOptions eagerLoad = null)
        {
            return base.GetByTreeParentIndex(treeIndex, eagerLoad) as UserList;
        }

        /// <summary>
        /// 查找指定树节点的直接子节点。
        /// </summary>
        /// <param name="treePId">需要查找的树节点的Id.</param>
        /// <param name="eagerLoad">需要贪婪加载的属性。</param>
        /// <returns></returns>
        [DebuggerStepThrough]
        public new UserList GetByTreePId(object treePId, EagerLoadOptions eagerLoad = null)
        {
            return base.GetByTreePId(treePId, eagerLoad) as UserList;
        }

        #endregion
    }
}