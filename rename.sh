# Test files renaming
find ./ -type f -name '*Leadify*' | while read -r file; do
    dir=$(dirname "$file")
    base=$(basename "$file")
    new_name=$(echo "$base" | sed 's/Leadify/TwoOneHomes/g')
    echo "Would rename file: $file -> $dir/$new_name"
     mv "$file" "$dir/$new_name"
done

# Test directories renaming
find ./ -type d -name '*Leadify*' | awk '{print length, $0}' | sort -nr | cut -d" " -f2- | while read -r dir; do
    parent=$(dirname "$dir")
    base=$(basename "$dir")
    new_name=$(echo "$base" | sed 's/Leadify/TwoOneHomes/g')
    echo "Would rename directory: $dir -> $parent/$new_name"
    mv "$dir" "$parent/$new_name"
done
