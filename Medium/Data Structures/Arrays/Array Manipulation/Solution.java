import java.io.*;
import java.math.*;
import java.security.*;
import java.text.*;
import java.util.*;
import java.util.concurrent.*;
import java.util.function.*;
import java.util.regex.*;
import java.util.stream.*;
import static java.util.stream.Collectors.joining;
import static java.util.stream.Collectors.toList;

class Result {

    /*
     * Complete the 'arrayManipulation' function below.
     *
     * The function is expected to return a LONG_INTEGER.
     * The function accepts following parameters:
     *  1. INTEGER n
     *  2. 2D_INTEGER_ARRAY queries
     */

    public static long arrayManipulation(int n, List<List<Integer>> queries) {
        // // Brute forch algorithm
         
        // long[] arr = new long[n];
        // for (List<Integer> query : queries) {
        //     // Parse query
        //     int a = query.get(0);
        //     int b = query.get(1);
        //     long k = query.get(2);
            
        //     // Add integer   
        //     for (int i = (int) a - 1; i <= b - 1; i++) {
        //         arr[i] += k;
        //     }
        // }
        
        // // Choose the largest number
        // long maxValue = 0;
        // for (int i = 0; i < arr.length; i++) {
        //     if (maxValue < arr[i]) {
        //         maxValue = arr[i];
        //     }
        // }
        
        // // for (int i = 0; i < arr.length; i++) {
        // //     System.out.print(arr[i] + " ");
        // // }    
        
        // return maxValue;
        
        // Optimized algorithm
        long[] arr = new long[n];
        for (List<Integer> query : queries) {
            // Parse query
            int a = query.get(0);
            int b = query.get(1);
            long k = query.get(2);
        
            // Record changes 
            arr[a - 1] += k;
            if (b+1 <= n) {
                arr[b] -= k;
            }
        }
        
        // Convert changes to actual values
        for (int i = 1; i < arr.length; i++) {
            arr[i] = arr[i-1] + arr[i];
        }
        
        // Choose the largest number
        long maxValue = 0;
        for (int i = 0; i < arr.length; i++) {
            if (maxValue < arr[i]) {
                maxValue = arr[i];
            }
        }
        
        return maxValue;
    }

}

public class Solution {
    public static void main(String[] args) throws IOException {
        BufferedReader bufferedReader = new BufferedReader(new InputStreamReader(System.in));
        BufferedWriter bufferedWriter = new BufferedWriter(new FileWriter(System.getenv("OUTPUT_PATH")));

        String[] firstMultipleInput = bufferedReader.readLine().replaceAll("\\s+$", "").split(" ");

        int n = Integer.parseInt(firstMultipleInput[0]);

        int m = Integer.parseInt(firstMultipleInput[1]);

        List<List<Integer>> queries = new ArrayList<>();

        IntStream.range(0, m).forEach(i -> {
            try {
                queries.add(
                    Stream.of(bufferedReader.readLine().replaceAll("\\s+$", "").split(" "))
                        .map(Integer::parseInt)
                        .collect(toList())
                );
            } catch (IOException ex) {
                throw new RuntimeException(ex);
            }
        });

        long result = Result.arrayManipulation(n, queries);

        bufferedWriter.write(String.valueOf(result));
        bufferedWriter.newLine();

        bufferedReader.close();
        bufferedWriter.close();
    }
}
