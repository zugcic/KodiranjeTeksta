using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KodiranjeTeksta {
	class KeyValues {

		int[] values;

		public KeyValues(int num) {

			this.values = new int[num];
		}

		public int this[int index] {
			get {
				return this.values[index];
			}
			set {
				this.values[index] = value;
			}
		}
	}
}
