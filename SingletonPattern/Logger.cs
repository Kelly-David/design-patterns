/*
 * @Author: David Kelly 
 * @Date: 2017-11-15 10:45:07 
 * @Last Modified by: david
 * @Last Modified time: 2017-11-15 10:45:56
 * @Brief: Singleton Pattern - Lazy single threaded example.
 */

public class Logger {
	private Logger() { }
	privat static Logger uniqueInstance = null;

	public static Logger getInstance() {
		if (uniqueInstance == null) {
			uniqueInstance = new Logger();
		}
		return uniqueInstance;
	}

	public void WriteLine(string text) { }
	public string ReadEntireLog() { return "Log Entries Here"; }
}