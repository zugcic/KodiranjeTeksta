using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KodiranjeTeksta {
	class ResultValues {

		int[] values;

		public ResultValues(int num) {

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
