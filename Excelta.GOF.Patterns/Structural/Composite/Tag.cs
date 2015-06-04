using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Excelta.GOF.Patterns.Structural.Composite
{
    public class Tag
    {
        private string _tagName;
        private string _id;
        protected List<KeyValuePair> _attributes;
        protected List<Tag> _subTags;

        public string GetId()
        {
            return _id;
        }

        public void SetId(string id)
        {
            _id = id;
        }


        public virtual void Add(Tag t)
        {
            if (_subTags == null)
                _subTags = new List<Tag>();
            _subTags.Add(t);
        }

        public virtual Tag Get(string id)
        {
            Tag result = null;
            if (_subTags == null)
                return result;
            foreach (Tag t in _subTags)
                if (t.GetId().Trim().ToUpper().Equals(id))
                {
                    result = t;
                    break;
                }

            return result;
        }


        #region Properties
        public string Name
        {
            get
            {
                return _tagName;

            }
        }

        public List<KeyValuePair> Attributes
        {
            get
            {
                return _attributes;
            }
        }

        #endregion

        #region Constructors

        public Tag(string tgName, List<KeyValuePair> attrs, List<Tag> subTags)
        {
            
            _tagName = tgName;
            _attributes = attrs;
            _subTags = subTags;

        }

        public Tag(string tgName, List<KeyValuePair> attrs)
            : this(tgName, attrs, new List<Tag>())
        {
        }

        public Tag(string tgName)
            : this(tgName, new List<KeyValuePair>())
        {
        }

        
        #endregion

    }
}
