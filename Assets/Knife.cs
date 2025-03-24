using System;
using UnityEngine;

namespace ChuongCustom
{
    public class Knife : Singleton<Knife>
    {
        public SpriteRenderer _skin;

        public void Flip()
        {
            rb.freezeRotation = false;
        }

        public void AddPoint()
        {
            ScoreManager.Score++;
        }

        public float force = 5;
        public float torque = 4;
        public float xForce = 10;
        private Rigidbody2D rb;

        void Start()
        {
            rb = GetComponent<Rigidbody2D>();

            _skin.sprite = SkinDataManager.Instance.CurrentSkin;
        }

        private void Update()
        {
            if (Input.GetMouseButtonDown(0))
            {
                AddForce(force);
            }
        }

        void AddForce(float force)
        {
            rb.AddTorque(torque);
            rb.AddForce(Vector2.up * force * xForce);
        }
        
        
    }
}