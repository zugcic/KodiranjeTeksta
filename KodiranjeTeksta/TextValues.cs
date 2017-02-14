using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KodiranjeTeksta {
	class TextValues {
		int[] values;

		TextValues(int num) {
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
