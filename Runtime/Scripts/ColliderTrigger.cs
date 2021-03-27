/*
 *	Copyright (c) 2021, AndtechGames
 *	All rights reserved.
 *	
 *	This source code is licensed under the BSD-style license found in the
 *	LICENSE file in the root directory of this source tree
 */

using System;
using UnityEngine;
using UnityEngine.Events;

namespace Andtech.Prototyping {
	[Serializable]
	public class ColliderEvent : UnityEvent<Collider> { }

	[RequireComponent(typeof(Collider))]
	public class ColliderTrigger : MonoBehaviour {
		public ColliderEvent TriggerEnter;
		public ColliderEvent TriggerStay;
		public ColliderEvent TriggerExit;

		private void OnTriggerEnter(Collider other) {
			TriggerEnter.Invoke(other);
		}

		private void OnTriggerStay(Collider other) {
			TriggerStay.Invoke(other);
		}

		private void OnTriggerExit(Collider other) {
			TriggerExit.Invoke(other);
		}
	}
}