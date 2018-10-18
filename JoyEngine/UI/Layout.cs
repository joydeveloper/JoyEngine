using System;
using System.Collections.Generic;
namespace JoyEngine
{
//    [Serializable]
//    public struct LayoutSettings
//    {
//        public LayoutSettings(RectOffset roffset, float spacing, TextAnchor txtanchor, Vector2 size)
//        {
//            Rectoffset = roffset;
//            Spacing = spacing;
//            Textanchor = txtanchor;
//            Size = size;

//        }
//        public RectOffset Rectoffset { get; set; }
//        public float Spacing { get; set; }
//        public TextAnchor Textanchor { get; set; }
//        public Vector2 Size { get; set; }
//    }
//    internal class Layouts
//    {

//        public List<Layout> Panels = new List<Layout>();
//        public void AddLayout(Layout lt)
//        {
//            Panels.Add(lt);

//        }
//        public void RemoveLayout(Layout lt)
//        {
//            Panels.Remove(lt);
//        }
//        public string name;
//        public void ToggleLayout(int id)
//        {
//            Panels[id].ToggleLayout();
//        }
//        public void ShowLayout(int id)
//        {
//            Panels[id].ShowLayout();
//        }
//        public void HideLayouts()
//        {
//            foreach (Layout lt in Panels)
//            {
//                lt.HideLayout();
//            }
            
//        }
//        public virtual void ToggleLayouts()
//        {
//            foreach (Layout lt in Panels)
//            {
//                lt.ToggleLayout();
//            }
//        }
//        public virtual void LayoutsSetup(RectOffset roffset, float spacing, TextAnchor txtanchor, Vector2 size)
//        {
//            foreach (Layout lt in Panels)
//            {
//                lt.LayoutSetup(roffset, spacing, txtanchor, size);
//            }
//        }
//        public virtual void LayoutsSetup(LayoutSettings ltsettings)
//        {
//            foreach (Layout lt in Panels)
//            {
//                lt.LayoutSetup(ltsettings);
//            }
//        }
//        public virtual void CreateLayouts(Transform trans)
//        {
//            foreach (Layout lt in Panels)
//            {
//                lt.CreateLayout(trans);
//            }

//        }
       

//    }
//    public abstract class Layout
//    {
       
//        public string name;
//        public bool isHorisontal;
//        internal GameObject _panel;
//        internal GameObject[] _elements;
//        public virtual void LayoutSetup(RectOffset roffset,float spacing,TextAnchor txtanchor,Vector2 size)
//        {

//          VerticalLayoutGroup vlg=  _panel.GetComponent<VerticalLayoutGroup>();
//          Debug.Log(vlg);
//          vlg.padding = roffset;
//          vlg.spacing = spacing;
//          vlg.childAlignment = txtanchor;
//            _panel.GetComponent<RectTransform>().sizeDelta = size;
//        }
//        public virtual void LayoutSetup(LayoutSettings ltsettings)
//        {

//            VerticalLayoutGroup vlg = _panel.GetComponent<VerticalLayoutGroup>();
//            Debug.Log(vlg);
//            vlg.padding = ltsettings.Rectoffset;
//            vlg.spacing = ltsettings.Spacing;
//            vlg.childAlignment =ltsettings.Textanchor;
//            _panel.GetComponent<RectTransform>().sizeDelta = ltsettings.Size;
//        }
//        internal virtual void CreateLayout(Transform trans)
//        {
//           _panel.transform.SetParent(trans);
//           _panel.GetComponent<RectTransform>().position = trans.GetComponent<RectTransform>().position;
//            if (isHorisontal)
//                _panel.AddComponent<HorizontalLayoutGroup>();
//            else
//                _panel.AddComponent<VerticalLayoutGroup>();
//            foreach (GameObject go in _elements)
//            {
//                go.transform.SetParent(_panel.transform);
//                go.AddComponent<LayoutElement>();
//                if (go.transform.Find("Label").GetComponent<Text>())
//                    Debug.Log(go.transform.Find("Label").GetComponent<Text>().text = go.name);
//                else
//                    Debug.Log("Componentnotfound");
//            }
//        }
//        public virtual void ToggleLayout()
//        {
//            _panel.SetActive(!_panel.activeSelf);

//        }
//        public virtual void HideLayout()
//        {
//            _panel.SetActive(false);

//        }
//        public virtual void ShowLayout()
//        {
//            _panel.SetActive(true);

//        }
//    }
//    public class SingleLayout : Layout
//    {
//        public SingleLayout(GameObject panel, GameObject[] elements, bool isHorizontal = true)
//        {
//            _panel = panel;
//            _elements = elements;
//        }
//        internal override void CreateLayout(Transform trans)
//        {
//            base.CreateLayout(trans);
//        }

//    }
//    internal class UIBuilder
//    {
//        internal UIBuilder()
//        {
//        }
//    }
}
