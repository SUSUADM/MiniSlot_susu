 using UnityEngine;
using UnityEngine.UI;

namespace JGM.Game.Rollers
{
    public class RollerItem : MonoBehaviour
    {
        public RollerItemType Type { get; private set; }

        [SerializeField]
        private Image _image;

        private Roller _roller;
        private float _moveSpeed;
        private float _bottomLimit;

        public float newSpeed_1 { set; get; }

        [Header("for 5 seconds ")]
        [SerializeField] private float speedValue_1;
        [SerializeField] private float speedValue_2;
        [SerializeField] private float speedValue_3;
        [SerializeField] private float speedValue_4;
        [SerializeField] private float speedValue_5;
        [SerializeField] private float speedValue_6;
        [SerializeField] private float speedValue_7;
        [SerializeField] private float speedValue_8;

        [Header("for 7 seconds ")]
        [SerializeField] private float speedValue_9;
        [SerializeField] private float speedValue_10;
        [SerializeField] private float speedValue_11;
        [SerializeField] private float speedValue_12;
        [SerializeField] private float speedValue_13;
        [SerializeField] private float speedValue_14;
        [SerializeField] private float speedValue_15;
        [SerializeField] private float speedValue_16;
        [SerializeField] private float speedValue_17;
        [SerializeField] private float speedValue_18;
        [SerializeField] private float speedValue_19;
        [SerializeField] private float speedValue_20;

        [Header("for 10 seconds ")]
        [SerializeField] private float speedValue_21;
        [SerializeField] private float speedValue_22;
        [SerializeField] private float speedValue_23;
        [SerializeField] private float speedValue_24;
        [SerializeField] private float speedValue_25;
        [SerializeField] private float speedValue_26;
        [SerializeField] private float speedValue_27;
        [SerializeField] private float speedValue_28;
        [SerializeField] private float speedValue_29;
        [SerializeField] private float speedValue_30;
        [SerializeField] private float speedValue_31;
        [SerializeField] private float speedValue_32;
        [SerializeField] private float speedValue_33;
        [SerializeField] private float speedValue_34;
        [SerializeField] private float speedValue_35;





        public void Initialize(Roller roller, RollerItemType type, Sprite sprite, float moveSpeed, float bottomLimit)
        {
            Debug.Log("Initialize");
            _roller = roller;
            Type = type;
            _image.sprite = sprite;
            _moveSpeed = moveSpeed;
            _bottomLimit = bottomLimit;
        }

        public void Spin()
        {
            
            bool isSpeedIncreased= Roller.instance.increasedSpeed;
            int timer= Roller.instance.spinTime;
            Debug.Log("rollername " + _roller.name);
            if (timer == 5)
            {
                _moveSpeed = 500;
                float itemTime_1 = 0;
                float div = 1;
                if (_roller.name == "roller_1")
                {
                    itemTime_1 = RollerManager.Instance._rollers[0].GetComponent<Roller>().totalTime;
                    div = 1;
                }
                else if (_roller.name == "roller_2")
                {
                    itemTime_1 = RollerManager.Instance._rollers[1].GetComponent<Roller>().totalTime;
                    div = 2;
                }
                else if (_roller.name == "roller_3")
                {
                    itemTime_1 = RollerManager.Instance._rollers[2].GetComponent<Roller>().totalTime;
                    div = 3;
                }


                itemTime_1 = itemTime_1 / div;
                if (itemTime_1 > 0 && itemTime_1 <= 1f)
                {
                    Debug.Log("Log_1");
                    _moveSpeed += speedValue_1;
                    newSpeed_1 = _moveSpeed;
                    Debug.Log("slot 1 " + newSpeed_1);

                }
                else if (itemTime_1 > 1f && itemTime_1 <= 1.5f)
                {
                    Debug.Log("Log_2");

                    _moveSpeed += speedValue_2;
                    newSpeed_1 = _moveSpeed;


                }
                else if (itemTime_1 > 1.5f && itemTime_1 <= 2.0f)
                {
                    Debug.Log("Log_2");

                    _moveSpeed += speedValue_3;
                    newSpeed_1 = _moveSpeed;


                }
                else if (itemTime_1 > 2.0f && itemTime_1 <= 2.5f)
                {
                    Debug.Log("Log_2");

                    _moveSpeed += speedValue_4;
                    newSpeed_1 = _moveSpeed;


                }
                else if (itemTime_1 > 2.5f && itemTime_1 <= 3.00f)
                {
                    Debug.Log("Log_2");

                    _moveSpeed += speedValue_5;
                    newSpeed_1 = _moveSpeed;


                }
                else if (itemTime_1 > 3.00f && itemTime_1 <= 4.00f)
                {
                    Debug.Log("Log_2");

                    _moveSpeed += speedValue_6;
                    newSpeed_1 = _moveSpeed;


                }
                else if (itemTime_1 > 4.0f && itemTime_1 <= 4.50f)
                {
                    Debug.Log("Log_2");

                    _moveSpeed += speedValue_7;
                    newSpeed_1 = _moveSpeed;


                }
                else if (itemTime_1 > 4.50f && itemTime_1 <= 5.00f)
                {
                    Debug.Log("Log_2");

                    _moveSpeed += speedValue_8;
                    newSpeed_1 = _moveSpeed;


                }



            }
            else if (timer == 7)
            {
                Debug.Log("In 7");
                _moveSpeed = 500;
                float itemTime_1 = 0;
                float div = 1;
                if (_roller.name == "roller_1")
                {
                    itemTime_1 = RollerManager.Instance._rollers[0].GetComponent<Roller>().totalTime;
                    div = 1;
                }
                else if (_roller.name == "roller_2")
                {
                    itemTime_1 = RollerManager.Instance._rollers[1].GetComponent<Roller>().totalTime;
                    div = 2;
                }
                else if (_roller.name == "roller_3")
                {
                    itemTime_1 = RollerManager.Instance._rollers[2].GetComponent<Roller>().totalTime;
                    div = 3;
                }


                itemTime_1 = itemTime_1 / div;
                if (itemTime_1 > 0 && itemTime_1 <= 1f)
                {
                    Debug.Log("Log_1.7");
                    _moveSpeed += speedValue_9;
                     newSpeed_1 = _moveSpeed;
                    Debug.Log("slot 1 " + newSpeed_1);

                }
                else if (itemTime_1 > 1f && itemTime_1 <= 1.5f)
                {
                    Debug.Log("Log_2.7");

                    _moveSpeed += speedValue_10;
                    newSpeed_1 = _moveSpeed;


                }
                else if (itemTime_1 > 1.5f && itemTime_1 <= 2.0f)
                {
                    Debug.Log("Log_3.7");

                    _moveSpeed += speedValue_11;
                    newSpeed_1 = _moveSpeed;


                }
                else if (itemTime_1 > 2.0f && itemTime_1 <= 2.5f)
                {
                    Debug.Log("Log_4.7");

                    _moveSpeed += speedValue_12;
                    newSpeed_1 = _moveSpeed;


                }
                else if (itemTime_1 > 2.5f && itemTime_1 <= 3.00f)
                {
                    Debug.Log("Log_5.7");

                    _moveSpeed += speedValue_13;
                    newSpeed_1 = _moveSpeed;


                }
                else if (itemTime_1 > 3.00f && itemTime_1 <= 4.00f)
                {
                    Debug.Log("Log_6.7");

                    _moveSpeed += speedValue_14;
                    newSpeed_1 = _moveSpeed;


                }
                else if (itemTime_1 > 4.0f && itemTime_1 <= 4.50f)
                {
                    Debug.Log("Log_7.7");

                    _moveSpeed += speedValue_15;
                    newSpeed_1 = _moveSpeed;


                }
                else if (itemTime_1 > 4.50f && itemTime_1 <= 5.00f)
                {
                    Debug.Log("Log_8.7");

                    _moveSpeed += speedValue_16;
                    newSpeed_1 = _moveSpeed;


                }
                if (itemTime_1 > 5.00f && itemTime_1 <= 5.50f)
                {
                    Debug.Log("Log_9.7");
                    _moveSpeed += speedValue_17;
                    newSpeed_1 = _moveSpeed;
                   

                }
                else if (itemTime_1 > 5.50f && itemTime_1 <= 6.00f)
                {
                    Debug.Log("Log_10.7");
                    _moveSpeed += speedValue_18;
                    newSpeed_1 = _moveSpeed;


                }
                else if (itemTime_1 > 6.00f && itemTime_1 <= 6.50f)
                {
                    Debug.Log("Log_11.7");

                    _moveSpeed += speedValue_19;
                    newSpeed_1 = _moveSpeed;


                }
                else if (itemTime_1 > 6.50f && itemTime_1 <= 7.00f)
                {
                    Debug.Log("Log_12.7");

                    _moveSpeed += speedValue_20;
                    newSpeed_1 = _moveSpeed;


                }



            }
            else if (timer == 10)
            {
                _moveSpeed =500;
                float itemTime_1 = 0;
                float div = 1;
                if (_roller.name == "roller_1")
                {
                    itemTime_1 = RollerManager.Instance._rollers[0].GetComponent<Roller>().totalTime;
                    div = 1;
                }
                else if (_roller.name == "roller_2")
                {
                    itemTime_1 = RollerManager.Instance._rollers[1].GetComponent<Roller>().totalTime;
                    div = 2;
                }
                else if (_roller.name == "roller_3")
                {
                    itemTime_1 = RollerManager.Instance._rollers[2].GetComponent<Roller>().totalTime;
                    div = 3;
                }


                itemTime_1 = itemTime_1 / div;
                if (itemTime_1 > 0 && itemTime_1 <= 1f)
                {
                    Debug.Log("Log_1.7");
                    _moveSpeed += speedValue_21;
                    newSpeed_1 = _moveSpeed;
                    Debug.Log("slot 1 " + newSpeed_1);

                }
                else if (itemTime_1 > 1f && itemTime_1 <= 1.5f)
                {
                    Debug.Log("Log_2.7");
                    _moveSpeed += speedValue_22;
                    newSpeed_1 = _moveSpeed;


                }
                else if (itemTime_1 > 1.5f && itemTime_1 <= 2.0f)
                {
                    Debug.Log("Log_3.7");
                    _moveSpeed += speedValue_23;
                    newSpeed_1 = _moveSpeed;


                }
                else if (itemTime_1 > 2.0f && itemTime_1 <= 2.5f)
                {
                    Debug.Log("Log_4.7");

                    _moveSpeed += speedValue_24;
                    newSpeed_1 = _moveSpeed;


                }
                else if (itemTime_1 > 2.5f && itemTime_1 <= 3.00f)
                {
                    Debug.Log("Log_5.7");

                    _moveSpeed += speedValue_25;
                    newSpeed_1 = _moveSpeed;


                }
                else if (itemTime_1 > 3.00f && itemTime_1 <= 4.00f)
                {
                    Debug.Log("Log_6.7");

                    _moveSpeed += speedValue_26;
                    newSpeed_1 = _moveSpeed;


                }
                else if (itemTime_1 > 4.00f && itemTime_1 <= 4.50f)
                {
                    Debug.Log("Log_7.7");

                    _moveSpeed += speedValue_27;
                    newSpeed_1 = _moveSpeed;


                }
                else if (itemTime_1 > 4.50f && itemTime_1 <= 5.00f)
                {
                    Debug.Log("Log_8.7");

                    _moveSpeed += speedValue_28;
                    newSpeed_1 = _moveSpeed;


                }
                if (itemTime_1 > 5.00f && itemTime_1 <= 5.50f)
                {
                    Debug.Log("Log_9.7");
                    _moveSpeed += speedValue_29;
                    newSpeed_1 = _moveSpeed;
                    Debug.Log("slot 1 " + newSpeed_1);

                }
                else if (itemTime_1 > 5.50f && itemTime_1 <= 6.00f)
                {
                    Debug.Log("Log_10.7");

                    _moveSpeed += speedValue_30;
                    newSpeed_1 = _moveSpeed;


                }
                else if (itemTime_1 > 6.00f && itemTime_1 <= 6.50f)
                {
                    Debug.Log("Log_11.7");

                    _moveSpeed += speedValue_31;
                    newSpeed_1 = _moveSpeed;


                }
                else if (itemTime_1 > 6.50f && itemTime_1 <= 7.00f)
                {
                    Debug.Log("Log_12.7");

                    _moveSpeed += speedValue_32;
                    newSpeed_1 = _moveSpeed;


                }
                else if (itemTime_1 > 7.00f && itemTime_1 <= 8.00f)
                {
                    Debug.Log("Log_12.7");

                    _moveSpeed += speedValue_33;
                    newSpeed_1 = _moveSpeed;


                }
                else if (itemTime_1 > 8.00f && itemTime_1 <= 9.00f)
                {
                    Debug.Log("Log_12.7");

                    _moveSpeed += speedValue_34;
                    newSpeed_1 = _moveSpeed;


                }
                else if (itemTime_1 > 9.00f && itemTime_1 <= 10.00f)
                {
                    Debug.Log("Log_12.7");

                    _moveSpeed += speedValue_35;
                    newSpeed_1 = _moveSpeed;


                }


            }


            transform.localPosition -= _moveSpeed * Time.deltaTime * Vector3.up;
            
            if (transform.localPosition.y < _bottomLimit)
            {
                transform.localPosition = _roller.GetLastItemLocalPosition() + _roller.GetSpacingBetweenItems();
                _roller.MoveFirstItemToTheBack();
            }
          
        }

        public void setImage(Sprite image)
        {
            _image.sprite = image;
        }

        public void setType(RollerItemType type)
        {
            Type = type;
        }

    }
}